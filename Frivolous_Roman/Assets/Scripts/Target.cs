using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float health = 2;
    public Animator animator;
    public Enemy enemy;

    private float delay = 3.0f;

    void Start()
    {
        health = Statics.AliensLifes;
        enemy = GetComponent<Enemy>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            animator.SetTrigger("die");
            Die();
        }
        else animator.SetTrigger("hit");
    }


    void Die()
    {
        enemy.Die();
        Statics.Score += 1;
        Destroy(gameObject, delay);
    }
}
