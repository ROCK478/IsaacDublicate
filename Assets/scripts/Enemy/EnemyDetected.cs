using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetected : MonoBehaviour
{
	private GameObject _hero;
	
    private void Awake()
	{
		_hero = GameObject.FindGameObjectWithTag("Player");
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
            transform.parent.gameObject.GetComponent<Enemy>().IsDetected = true;
		}
	}
}
