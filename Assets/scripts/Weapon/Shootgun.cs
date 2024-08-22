using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootgun : Weapon
{
    [SerializeField]private int _pellets = 8;
    [SerializeField]private float _spreadAngle = 0f;
    public static bool IsShootgun = false;
    public static float TimeLifeBullet = 0.5f;
    private void Awake()
    {
        BulletSpeed = 20f;
        mainCamera = Camera.main;
        FirePoint = GameObject.Find("FirePointShootgun").transform;
    }

    private void Start()
    {
        CurrentWeapon = this.gameObject;
        IsShootgun = true;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Fire)
        {
            ShootForShootgun();
            TimeForShoot = TimerDuration;
        }
        Timer();
    }

    private void ShootForShootgun()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 targetPoint = hit.point;
            Vector3 shootDirection = (targetPoint - FirePoint.position).normalized;
            for (int i = 0; i < _pellets; i++)
            {
                Quaternion spreadRotation = Quaternion.Euler(
                    UnityEngine.Random.Range(-_spreadAngle, _spreadAngle),
                    UnityEngine.Random.Range(-_spreadAngle, _spreadAngle),
                    0
                );
                GameObject bullet = Instantiate(BulletPrephab, FirePoint.position, Quaternion.LookRotation(spreadRotation * shootDirection));
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.velocity = shootDirection * BulletSpeed;
            }
        }
    }
}
