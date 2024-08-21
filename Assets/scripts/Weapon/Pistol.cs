using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    private void Awake()
    {
        bulletSpeed = 20f;
        mainCamera = Camera.main;
        FirePoint = GameObject.Find("FirePointPistol").transform;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
}
