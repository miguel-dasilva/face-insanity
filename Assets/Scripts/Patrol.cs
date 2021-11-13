using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Patrol : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private float distanceToPlayer;
    private GameObject player;
    private Transform target;
    public float sight;
    public float sightAngle;
    public bool playerSeen;
    public Light light;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.GetComponent<Transform>();

        agent.autoBraking = false;
        playerSeen = false;

        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        if (points.Length == 0)
            return;

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        Vector3 playerPosition = target.position;
        Vector3 vectorToPlayer = playerPosition - transform.position;
        distanceToPlayer = Vector3.Distance(playerPosition, transform.position);

        if (playerSeen)
        {
            if (distanceToPlayer > sight)
            {
                light.color = Color.white;
                playerSeen = false;
                agent.destination = points[destPoint].position;
            }
            else
            {
                light.color = Color.red;
                agent.transform.LookAt(playerPosition);
                agent.SetDestination(target.position);
            }

        }
        else if (distanceToPlayer <= sight && Vector3.Angle(transform.forward, vectorToPlayer) <= sightAngle) //Player spotted
        {
            playerSeen = true;
        }
        
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }

    }
}
