using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    private bool _fire = true;
    [SerializeField][Range(0f, 1f)] private float _timerDuration;
    private float _timer;

    private void Awake()
    {
        bulletSpeed = 20f;
        mainCamera = Camera.main;
        FirePoint = GameObject.Find("FirePointRifle").transform;
        Pistol = false;
        Rifle = true;
        Shootgun = false;
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && _fire)
        {
            Shoot();
            _timer = _timerDuration;
        }
        Timer();
    }

    private void Timer()
    {
        if (_timer > 0)
        {
            _fire = false;
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                _fire = true;
            }
        }

    }
}
