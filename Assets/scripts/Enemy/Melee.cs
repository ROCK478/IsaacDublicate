using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : Enemy
{
    private GameObject _hero;
    public float _speed;
    public int _damage = 20;

    private void Awake()
    {
        _hero = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (IsDetected)
        {
            Vector3 _direction = _hero.transform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(_direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
            _direction = (_hero.transform.position - transform.position).normalized;
            Rigidbody EnemyRB = gameObject.GetComponent<Rigidbody>();
            EnemyRB.velocity = _direction * _speed;
        }
    }
}
