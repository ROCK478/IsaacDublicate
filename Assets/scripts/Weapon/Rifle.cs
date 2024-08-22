using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    private void Awake()
    {
        BulletSpeed = 20f;
        mainCamera = Camera.main;
        FirePoint = GameObject.Find("FirePointRifle").transform;
    }

    private void Start()
    {
        IsPistol = false;
        IsRifle = true;
        IsShootgun = false;
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && Fire)
        {
            Shoot();
            TimeForShoot = TimerDuration;
        }
        Timer();
    }
}
