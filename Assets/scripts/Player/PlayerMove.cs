using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour // Персонаж двигается
{
    [SerializeField][Range(0, 100f)] private float _walkSpeed;
	private Rigidbody _rb;
	
	private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
	
	private void Update()
    {
        Walk();
    }
	
	private void Walk()
	{
		_rb.velocity = new Vector3(Input.GetAxis("Horizontal") * _walkSpeed, _rb.velocity.y, Input.GetAxis("Vertical") * _walkSpeed);
	}
	
}
