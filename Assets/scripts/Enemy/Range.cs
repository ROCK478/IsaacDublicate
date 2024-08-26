using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : Enemy
{
    private GameObject _hero;
    [SerializeField] private GameObject BulletPrephabEnemy;
    [SerializeField] private float _bulletSpeedEnemy;
    //Таймер для нормальной стрельбы
    [NonSerialized] public bool Fire = true;
    [Range(0f, 10f)] public float TimerDuration; // Задержка между выстрелами
    [NonSerialized] public float TimeForShoot;

    private void Awake()
    {
        _hero = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (IsDetected)
        {
            transform.LookAt(_hero.transform);
            if (Fire)
            {
                Shoot();
                TimeForShoot = TimerDuration;
                
            }
            Timer();
        }
    }

    private void Shoot()
    {
        Transform FirePoint = transform.Find("Rifle").transform.Find("FirePointRifle").transform;
        Vector3 targetPosition = _hero.transform.position;
        Vector3 direction = (targetPosition - FirePoint.position).normalized;
        GameObject bullet = Instantiate(BulletPrephabEnemy, FirePoint.position, FirePoint.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.velocity = direction * _bulletSpeedEnemy;
    }

    private void Timer()
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
