using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent _agent;

    public GameObject Player;

    private float EnemySeeDistance = 50.0f;
    private float EnemyAttackDistance = 2.5f;

    public Animator animator;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

   

    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        {
            if (distance < EnemyAttackDistance)
            {
                Attack(true);
                Walk(false);
                _agent.isStopped = true;
            }

            if (distance < EnemySeeDistance && distance > EnemyAttackDistance)
            {
                Vector3 dirToPlayer = Player.transform.position - transform.position;
                Vector3 newPos = transform.position + dirToPlayer;
                Attack(false);
                Walk(true);
                _agent.isStopped = false;
                _agent.SetDestination(newPos);
            }

            if (distance >= EnemySeeDistance)
            {
                Walk(false);
                Attack(false);
                _agent.isStopped = true;
            }

        }
    }

    private void Walk(bool value)
    {
        animator.SetBool("walk", value);
    }

    private void Attack(bool value)
    {
        animator.SetBool("attack", value);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && animator.GetBool("attack"))
        {
            HealthAndFuel target = col.transform.GetComponent<HealthAndFuel>();
            StartCoroutine(TakeLife(target));
        }
    }

    private IEnumerator TakeLife(HealthAndFuel target)
    {
        yield return new WaitForSeconds(0.5f);
        target.TakeDamage(1);
    }

    public void Die()
    {
        _agent.isStopped = true;
        _agent.velocity = Vector3.zero;
    }
}