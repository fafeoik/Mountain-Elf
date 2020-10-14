using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject player;
    private Transform target;
    Animator anim;

    public float dist;
    NavMeshAgent nav;
    public float radius = 15;

    public float HP = 100;
    public GameObject Ragdoll;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        target = player.transform;
    }

    void Update()
    {
        if (HP <= 0)
        {
            Instantiate(Ragdoll, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        dist = Vector3.Distance(player.transform.position, transform.position);
        if(dist > radius)
        {
            nav.enabled = false;
            gameObject.GetComponent<Animator>().SetTrigger("idle");
        }
        if(dist < radius && dist > 1.5f)
        {
            nav.enabled = true;
            agent.SetDestination(target.position);
            gameObject.GetComponent<Animator>().SetTrigger("run");
        }
        if(dist < 1.5f)
        {
            gameObject.GetComponent<Animator>().SetTrigger("attack");

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerSword1")
        {
            HP -= 25f;
        }
    }
}