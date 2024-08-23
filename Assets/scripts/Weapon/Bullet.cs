using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    public static bool BuffSize = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (Shootgun.IsShootgun)
        {
            Destroy(this.gameObject, Shootgun.TimeLifeBullet);
        }
        else if (collision.gameObject.name == "Wall")
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        if (BuffSize)
        {
            transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        }
    }



}
