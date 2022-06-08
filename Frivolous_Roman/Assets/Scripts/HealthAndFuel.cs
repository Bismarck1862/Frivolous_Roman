using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthAndFuel : MonoBehaviour
{
    public Bar healthBar;
    public Bar fuelBar;

    void Start()
    {
        healthBar.SetMax(Statics.HeroLifesStart);
        fuelBar.SetMax(Statics.fuelStart);
    }

    void Update()
    {
        fuelBar.Set(Statics.fuel);
    }

    void TakeDamage(int damage)
    {
        Debug.Log("hit");
        Statics.HeroLifes -= damage;
        healthBar.Set(Statics.HeroLifes);
        if (Statics.HeroLifes <= 0)
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
        if (col.gameObject.tag == "Enemy")
        {
            //TakeDamage(1);
        }
    }
}
