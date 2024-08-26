using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    public static bool BuffSize = false;
    private int _damage = 20;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<Enemy>().TakeDamage(_damage);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(_damage);
        }
    }

    private void Start()
    {
        if (BuffSize)
        {
            transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        }
        Destroy(this.gameObject, Shootgun.TimeLifeBullet);
    }
}
