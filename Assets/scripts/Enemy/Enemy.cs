using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
	private float _currentHealth;
	[SerializeField] private float _runSpeed;
	[SerializeField] private float _bulletSpeed;
	
	private void Start()
	{
		_currentHealth = _maxHealth;
	}
	
	public void TakeDamage(int damage) // Получение урона
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            Destroy(this.gameObject);
        };
    }
}
