using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    private void Awake()
    {
        FirePoint = GameObject.Find("FirePointRifle").transform;
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
