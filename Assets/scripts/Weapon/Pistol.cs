using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    private void Awake()
    {
        BulletSpeed = 20f;
        mainCamera = Camera.main;
        FirePoint = GameObject.Find("FirePointPistol").transform;
    }

    private void Update()
    {
        if (FirePoint == null)
        {
            FirePoint = GameObject.Find("FirePointPistol").transform;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
}
