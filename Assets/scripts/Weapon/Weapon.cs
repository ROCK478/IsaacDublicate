using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Camera mainCamera;
    public float bulletSpeed;
    public GameObject BulletPrephab;
    public Transform FirePoint;
    public LayerMask GroundLayer;
    public static bool Pistol = true;
    public static bool Rifle = false;
    public static bool Shootgun = false;


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
            bulletRb.velocity = direction * bulletSpeed;
        }
    }
}
