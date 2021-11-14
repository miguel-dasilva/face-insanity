using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Patrol : MonoBehaviour
{
    public Transform[] points;

    public float hp = 100;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private float distanceToPlayer;
    private GameObject player;
    private Transform target;
    public float sight;
    public float sightAngle;
    public bool playerSeen;
    public Light light;
    public float enemyHearsPlayerRadius;

    private CharController playerController;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<CharController>();
        target = player.GetComponent<Transform>();

        agent.autoBraking = false;
        playerSeen = false;

        GotoNextPoint();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && playerController.isHidden == false)
        {
            // function to attack including animation
            playerController.hp -= 20;

        }

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
        if (hp <= 0)
        {
            Destroy(this);
        }

        if (playerSeen)
        {
            if (distanceToPlayer > sight)
            {
                light.color = Color.white;
                playerSeen = false;
                playerController.playerSeen = false;

                agent.destination = points[destPoint].position;
            }
            else
            {
                light.color = Color.red;
                agent.transform.LookAt(playerPosition);
                agent.SetDestination(target.position);
            }
            agent.speed = 12.0f;
            agent.acceleration = 30.0f;

        }
        else if (distanceToPlayer <= sight && Vector3.Angle(transform.forward, vectorToPlayer) <= sightAngle) //Player spotted
        {
            playerSeen = true;
            playerController.playerSeen = true;
        }
        else
        {
            agent.speed = 5.0f;
            agent.acceleration = 8.0f;

        }

        if (distanceToPlayer <= enemyHearsPlayerRadius && playerController.isHidden == false)
        {
            playerSeen = true;
            playerController.playerSeen = true;

        }


        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }


    }
}
