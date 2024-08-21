using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRifle : MonoBehaviour
{
    [SerializeField] private GameObject _pistol;
    [SerializeField] private GameObject _rifle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            _pistol.SetActive(false);
            _rifle.SetActive(true);
            
        }
    }
}
