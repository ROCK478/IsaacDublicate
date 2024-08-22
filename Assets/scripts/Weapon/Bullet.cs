using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
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
}
