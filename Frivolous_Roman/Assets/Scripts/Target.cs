using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 30f;
    public Animator animator;
    
    private float delay = 2.0f;

    void Start()
    {
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        animator.SetBool("getHit", true);
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetBool("getHit", false);
        animator.SetBool("die", true);
        Statics.Score += 1;
        Destroy(gameObject, delay);
    }
}
