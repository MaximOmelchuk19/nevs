using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHealth : MonoBehaviour
{


    public HealthBar healthBar;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
        if (healthBar.GetHealth() <= 0)
        {
            Debug.Log("Player Dead");

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
           FullHeal();
        }
    }
    void FullHeal()
    {
        healthBar.SetHealth(healthBar.GetMaxHealth());
    }
    void TakeDamage(int damage)
    {
        healthBar.SetHealth(healthBar.GetHealth() - damage);
    }
}
