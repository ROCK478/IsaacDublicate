using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform _playerSpawn;
	[SerializeField] private GameObject _hero;
	[SerializeField] private Transform _camera;
	public bool DoorRight = false;
	public bool DoorLeft = false;
	public bool DoorUp = false;
	public bool DoorDown = false;
	public bool IsLocked = false;
	
	public void Awake()
	{
		_camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}
	
	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Instantiate(_hero, _playerSpawn.position, _playerSpawn.rotation);
			CameraMove();
		}
	}
	
	private void CameraMove()
	{
		if (DoorRight)
		{
			_camera.position = new Vector3(0,0,0);
		}
		else if (DoorLeft)
		{
			_camera.position = new Vector3(0,0,0);
		}
		else if (DoorUp)
		{
			_camera.position = new Vector3(0,0,0);
		}
		else if (DoorDown)
		{
			_camera.position = new Vector3(0,0,0);
		};
	}
}
