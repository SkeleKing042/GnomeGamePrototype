//Created by Jackson Lucas
//Last Edited by Jackson Lucass

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyGnomeAI : MonoBehaviour
{
    private NavMeshAgent _agent;
    public float HitPoints = 10;
    public ParticleSystem DeathParticles;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(FindObjectOfType<PlayerMovment>().gameObject.transform.position);
    }

    public float ReciveDamage(float value)
    {
        HitPoints -= value;
        if (HitPoints <= 0)
            Death();

        return value;
    }
    public void Death()
    {
        GameObject dp = Instantiate(DeathParticles, transform.position, Quaternion.identity).gameObject;
        Destroy(dp, 3);
        Destroy(gameObject);
    }
}
