using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 30f;
    public Animator animator;
    
    private float delay = 3.0f;

    void Start()
    {
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
        Statics.Score += 1;
        Destroy(gameObject, delay);
    }
}
