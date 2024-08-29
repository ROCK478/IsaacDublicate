using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    int damage = 20;
    private GameObject enemy;

    private void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);

        if (collision.gameObject.tag == "Enemy")
        {
            enemy.GetComponent<Enemy>().TakeDamage(damage);
        }
    }
}
