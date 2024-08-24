using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    private GameObject _currentWeapon;
    [SerializeField] private GameObject _riflePrephab;
    [SerializeField] private GameObject _shootgunPrephab;
    private GameObject _weaponSpawn;

    private void Awake()
    {
        _currentWeapon = GameObject.FindGameObjectWithTag("Weapon");
    }

    private void Update()
    {
        if (Weapon.IsRifle && Door.NewHeroCreate)
        {
            _currentWeapon = GameObject.FindGameObjectWithTag("Weapon");
            _weaponSpawn = GameObject.Find("WeaponSpawn");
            GameObject _newWeapon = Instantiate(_riflePrephab, _weaponSpawn.transform.position, _weaponSpawn.transform.rotation);
            _newWeapon.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
            //Destroy(_currentWeapon);
            Door.NewHeroCreate = false;
        }
        else if (Weapon.IsShootgun && Door.NewHeroCreate)
        {
            _currentWeapon = GameObject.FindGameObjectWithTag("Weapon");
            _weaponSpawn = GameObject.Find("WeaponSpawn");
            GameObject _newWeapon = Instantiate(_shootgunPrephab, _weaponSpawn.transform.position, _weaponSpawn.transform.rotation);
            _newWeapon.transform.SetParent(GameObject.FindGameObjectWithTag("Player").transform);
            //Destroy(_currentWeapon);
            Door.NewHeroCreate = false;
        }
    }
}
