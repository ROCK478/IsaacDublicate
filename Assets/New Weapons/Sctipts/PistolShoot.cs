using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolShoot : MonoBehaviour
{
    public GameObject bulletPrf;

    public float bulletSpeed;
    private float lastFire;
    public float fireDelay;

    private void Update()
    {
        float shootHor = Input.GetAxis("ShootHorizontal");
        float shootVer = Input.GetAxis("ShootVertical");

        if (((shootHor != 0 || shootVer != 0) && Time.time > lastFire + fireDelay) & gameObject.GetComponent<WeaponHold>().hold)
        {
            Shooting(shootHor, shootVer);
            lastFire = Time.time;   
        }
    }

    void Shooting(float x, float y)
    {
        GameObject bullet = Instantiate(bulletPrf, transform.position, transform.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().velocity = new Vector3(
            (x < 0) ? Mathf.Floor(x) : Mathf.Ceil(x), 0,
            (y < 0) ? Mathf.Floor(y) : Mathf.Ceil(y)).normalized * bulletSpeed;
    }
}

