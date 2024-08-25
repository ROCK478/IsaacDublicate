using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Shootgun : Weapon
{
    private int _pellets = 3; //����� � ���������� ������� �������� �� ��� ��������
    public static float TimeLifeBullet = 0.5f; //��������

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Fire)
        {
            ShootForShootgun();
            TimeForShoot = TimerDuration;
        }
        Timer();
    }

    private void ShootForShootgun() // ��������� ����������� �� ����� ������ ���� �� ������� ����������� ��������. ����� ����� ���� �������� ��������� � ���� �����������.
    {
        for (int i = 0; i < _pellets; i++)
        {
            FirePoint = GameObject.Find($"FirePointShootgun{i}").transform;
            Vector3 targetPosition = GameObject.Find($"TargetPosition{i}").transform.position;
            Vector3 direction = (targetPosition - FirePoint.position).normalized;
            GameObject bullet = Instantiate(BulletPrephab, FirePoint.position, FirePoint.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = direction * BulletSpeed;
        }
    }
}
