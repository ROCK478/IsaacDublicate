using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PickUpRifle : MonoBehaviour
{
    private GameObject _pistol;
    [SerializeField] GameObject _riflePrephab;
    private GameObject _hero;
    private GameObject _weaponSpawn;

    private void Awake()
    {
        _pistol = GameObject.Find("Pistol");
        _hero = GameObject.Find("hero");
        _weaponSpawn = GameObject.Find("WeaponSpawn");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            RifleInInventory();
        }
    }

    private void RifleInInventory()
    { 
        GameObject _rifle = Instantiate(_riflePrephab, _weaponSpawn.transform.position, _weaponSpawn.transform.rotation);
        _rifle.transform.SetParent(_hero.transform);
        Destroy(_pistol);
    }
}
