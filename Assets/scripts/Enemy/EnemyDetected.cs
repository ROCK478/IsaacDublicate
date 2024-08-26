using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetected : MonoBehaviour
{
	private GameObject _hero;
	public float _speed;
	public bool IsRange = false;
	public bool IsMelee = false;
	
    private void Awake()
	{
		_hero = GameObject.FindGameObjectWithTag("Player");
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (IsRange && other.gameObject.tag == "Player")
		{
			transform.parent.gameObject.transform.LookAt(_hero.transform);
		}
		else if (IsMelee && other.gameObject.tag == "Player")
		{
			Vector3 _direction = _hero.transform.position - transform.position;
			Quaternion targetRotation = Quaternion.LookRotation(_direction);
			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
			_direction = (_hero.transform.position - transform.position).normalized;
			Rigidbody EnemyRB = transform.parent.gameObject.GetComponent<Rigidbody>();
            EnemyRB.velocity = _direction * _speed;
		}
	}
}
