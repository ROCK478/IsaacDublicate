using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHeath(maxHealth);
    }

    public void TakeDamage(int damage) // Получение урона
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0) // Рестарт уровни, если здоровье игрока достигает нуля
        {
            Debug.Log("You Lost!!");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
