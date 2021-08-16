using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{

    public Transform patrolRoute;
    public Transform player;
    public List<Transform> locations;


    private int locationsIndex = 0;
    private NavMeshAgent agent;
    private int _lives = 3;

    public int EnemyLives
    {
        get { return _lives; }

        private set
        {
            _lives = value;

            if(_lives <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Enemy down");
            }
        }
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        player = GameObject.Find("Player").transform;

        InitializePatrolRoute();

        MoveToNextPatrolPoint();
        
    }

    void Update()
    {
        if(agent.remainingDistance < 0.2f && !agent.pathPending)
        {
            MoveToNextPatrolPoint();
        }
        
    }

    void MoveToNextPatrolPoint()
    {
        if(locations.Count == 0)
        {
            return;
        }
        agent.destination = locations[locationsIndex].position;
        locationsIndex = (locationsIndex + 1) % locations.Count;
    }

    void InitializePatrolRoute()
    {
        foreach(Transform child in patrolRoute)
        {
            locations.Add(child);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            agent.destination = player.position;
            Debug.Log("Player detected -- ATTACK!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            EnemyLives -= 1;
            Debug.Log("Critical Hit!");
        }
    }
}
