using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _maxHealth;
	[SerializeField] private float _currentHealth;
	GameObject playerBullet;
	public bool IsDetected = false;
	
	private void Start()
	{
		_maxHealth = 100;
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
