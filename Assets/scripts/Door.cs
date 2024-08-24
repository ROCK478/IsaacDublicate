using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform _playerSpawn;
	[SerializeField] private GameObject _hero;

	private Transform _camera;
	public bool DoorRight = false;
	public bool DoorLeft = false;
	public bool DoorUp = false;
	public bool DoorDown = false;
	public bool IsOpen = true;
	public static bool NewHeroCreate = false;
	
	public void Awake()
	{
		_camera = GameObject.FindGameObjectWithTag("MainCamera").transform;

    }
	
	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && IsOpen)
		{
			other.transform.position = _playerSpawn.position; // Изменение позиции игрока, вместо клонирование экезмпляра
			//Instantiate(_hero, _playerSpawn.position, _playerSpawn.rotation);
			CameraMove();
			//Destroy(other.gameObject);
			if (Weapon.IsPistol == false)
			{
                NewHeroCreate = true;
            }
        }
	}
	
	private void CameraMove()
	{	
		if (DoorRight)
		{
			_camera.position = new Vector3(_camera.position.x + 60, _camera.position.y, _camera.position.z);
		}
		else if (DoorLeft)
		{
			_camera.position = new Vector3(_camera.position.x - 60, _camera.position.y, _camera.position.z);
		}
		else if (DoorUp)
		{
			_camera.position = new Vector3(_camera.position.x, _camera.position.y, _camera.position.z + 32.5f);
		}
		else if (DoorDown)
		{
			_camera.position = new Vector3(_camera.position.x, _camera.position.y, _camera.position.z - 32.5f);
		};
	}
}
