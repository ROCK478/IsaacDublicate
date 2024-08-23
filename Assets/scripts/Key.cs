using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject _lockedDoor;
    private Door _door;

    public void Awake()
    {
        _door = _lockedDoor.GetComponent<Door>();
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _door.IsOpen = true;
            Destroy(this.gameObject);
        }
    }
}
