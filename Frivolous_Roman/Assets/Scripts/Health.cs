using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int currentHealth;

    public HealthBar healthBar;


    void Start()
    {
        currentHealth = Statics.HeroLifesStart;
        healthBar.SetMaxHealth(Statics.HeroLifesStart);
    }

    void Update()
    {
        healthBar.SetMaxHealth(Statics.HeroLifes);
        /*if (Statics.Score <= 0)
        {
            Die();
        }*/
    }

    void TakeDamage(int damage)
    {
        Debug.Log("hit");
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("Menu");
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("enemy");
        if (col.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }
}
