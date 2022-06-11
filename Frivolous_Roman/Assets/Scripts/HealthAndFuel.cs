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
        healthBar.SetMax(Statics.HeroLifes);
        fuelBar.SetMax(Statics.fuel);
    }

    void Update()
    {
        fuelBar.Set(Statics.fuel);
        healthBar.Set(Statics.HeroLifes);
    }

    public void TakeDamage(int damage)
    {
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

}
