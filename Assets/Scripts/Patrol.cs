using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Patrol : MonoBehaviour
{
    public Transform[] points;

    public float attackRange = 1.5f;
    public float hp = 100.0f;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private float distanceToPlayer;
    private GameObject player;
    public GameObject mRightFist;
    private Transform target;
    public float sight;
    public float sightAngle;
    public bool playerSeen;
    public Light light;
    public float enemyHearsPlayerRadius;
    public Animator animator;
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

    void GotoNextPoint()
    {
        if (points.Length == 0)
            return;

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }

    public void activateFist()
    {
        mRightFist.GetComponent<Collider>().enabled = true;
    }

    public void deactivateFist()
    {
        mRightFist.GetComponent<Collider>().enabled = false;
    }

    public void damaged()
    {
        animator.SetTrigger("Damaged");
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
                if (distanceToPlayer <= attackRange)
                {
                    animator.SetTrigger("Attack");
                }
                else
                {
                    light.color = Color.red;
                    agent.transform.LookAt(playerPosition);
                    agent.SetDestination(target.position);
                }
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
