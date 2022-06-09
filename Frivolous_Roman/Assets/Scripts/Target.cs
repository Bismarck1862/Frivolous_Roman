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
        if (health <= 0f)
        {
            StartCoroutine(DieCor());
        }
        else StartCoroutine(GetHit());
    }

    IEnumerator GetHit()
    {
        animator.SetBool("getHit", true);
        yield return new WaitForSeconds(0.8f);
        animator.SetBool("getHit", false);
    }

    IEnumerator DieCor()
    {
        animator.SetBool("die", true);
        animator.SetBool("getHit", false);
        yield return new WaitForSeconds(2);
        animator.SetBool("die", false);
        Die();
    }



    void Die()
    {
        Statics.Score += 1;
        Destroy(gameObject, delay);
    }
}
