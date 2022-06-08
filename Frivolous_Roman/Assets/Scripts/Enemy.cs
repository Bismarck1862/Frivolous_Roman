using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent _agent;

    public GameObject Player;

    public float EnemySeeDistance = 20.0f;
    public float EnemyAttackDistance = 3.0f;

    public Animator animator;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (animator.GetBool("getHit") || animator.GetBool("die"))
        {
            Walk(false);
            animator.SetBool("attack", false);
            _agent.isStopped = true;
            animator.SetBool("getHit", false);
        }
        else
        {
            bool attack = distance < EnemyAttackDistance;
            Debug.Log(distance);
            Debug.Log(attack);
            animator.SetBool("attack", attack);
            Walk(!attack);
            _agent.isStopped = attack;

            if (distance < EnemySeeDistance && distance > EnemyAttackDistance)
            {
                Vector3 dirToPlayer = Player.transform.position - transform.position;
                Vector3 newPos = transform.position + dirToPlayer;
                Walk(true);
                _agent.SetDestination(newPos);
            }
            else
            {
                Walk(false);
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
        Debug.Log("sth");
        if (col.gameObject.tag == "Player" && animator.GetBool("attack"))
        {
            Debug.Log("player");
        }
    }
}