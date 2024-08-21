using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    private void Awake()
    {
        bulletSpeed = 30f;
        mainCamera = Camera.main;
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }
}
