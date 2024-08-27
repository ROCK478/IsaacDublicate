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

    public void TakeDamage(int damage) // ��������� �����
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0) // ������� ������, ���� �������� ������ ��������� ����
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void TakeHeal(int  heal)
    {
        if (currentHealth + heal > 100)
            currentHealth = 100;
        else
            currentHealth += heal;
        healthBar.SetHealth(currentHealth);
    }
}
