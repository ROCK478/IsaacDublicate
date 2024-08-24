using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThornDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    int thornDamage = 20;

    private void OnCollisionEnter(Collision collision) // Соприкосновение с шипом 
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(thornDamage);
            Debug.Log("Ouch, Fuck!!!");
        }
    }

}
