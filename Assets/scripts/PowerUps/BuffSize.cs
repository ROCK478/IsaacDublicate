using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSize : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        Bullet.BuffSize = true;
    }
}
