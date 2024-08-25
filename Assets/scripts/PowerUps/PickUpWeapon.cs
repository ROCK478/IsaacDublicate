using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour //Подбор оружия
{
    private GameObject _currentWeapon;
    [SerializeField] GameObject _newWeaponPrephab;
    private GameObject _hero;
    private GameObject _weaponSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _weaponSpawn = GameObject.Find("WeaponSpawn");
            _hero = GameObject.FindGameObjectWithTag("Player");
            _currentWeapon = GameObject.FindGameObjectWithTag("Weapon");
            Destroy(this.gameObject);
            ChangeWeapon();
        }
    }

    private void ChangeWeapon() // Меняет нынешнее оружие на подобранное
    { 
        GameObject _newWeapon = Instantiate(_newWeaponPrephab, _weaponSpawn.transform.position, _weaponSpawn.transform.rotation);
        _newWeapon.transform.SetParent(_hero.transform);
        Destroy(_currentWeapon);
    }
}
