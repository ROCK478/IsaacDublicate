using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThornDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    int thornDamage = 20;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("hero"))
        {
            playerHealth.TakeDamage(thornDamage);
            Debug.Log("Ouch, Fuck!!!");
        }
    }

}
