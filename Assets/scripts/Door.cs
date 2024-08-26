using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform _playerSpawn;
	[SerializeField] private GameObject _hero;
	[SerializeField] Transform cameraSpawn;

	private Transform _camera;
	public bool IsOpen = true;
	
	public void Awake()
	{
		_camera = GameObject.FindGameObjectWithTag("MainCamera").transform;

    }
	
	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && IsOpen)
		{
			other.transform.position = _playerSpawn.position; // Изменение позиции игрока, вместо клонирование экезмпляра
            _camera.position = cameraSpawn.position;
        }
	}
}
