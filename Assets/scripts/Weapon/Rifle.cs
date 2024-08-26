using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    private void Awake()
    {
        FirePoint = transform.Find("FirePointRifle").transform;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) && Fire)
        {
            Shoot();
            TimeForShoot = TimerDuration;
        }
        Timer();
    }
}
