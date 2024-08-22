using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Weapon : MonoBehaviour
{
    [NonSerialized] public Camera mainCamera;
    public float BulletSpeed;
    public GameObject BulletPrephab;
    [NonSerialized] public Transform FirePoint;
    public LayerMask GroundLayer;
    [NonSerialized] public static bool IsPistol = true;
    [NonSerialized] public static bool IsRifle = false;
    [NonSerialized] public static bool IsShootgun = false;
    //Таймер для нормальной стрельбы
    [NonSerialized] public bool Fire = true;
    [Range(0f, 10f)] public float TimerDuration;
    [NonSerialized] public float TimeForShoot;


    public void Shoot()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, GroundLayer))
        {
            Vector3 targetPosition = hit.point;
            Vector3 direction = (targetPosition - FirePoint.position).normalized;
            GameObject bullet = Instantiate(BulletPrephab, FirePoint.position, Quaternion.identity);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = direction * BulletSpeed;
        }
    }

    public void Timer()
    {
        if (TimeForShoot > 0)
        {
            Fire = false;
            TimeForShoot -= Time.deltaTime;
            if (TimeForShoot <= 0)
            {
                Fire = true;
            }
        }
    }
}
