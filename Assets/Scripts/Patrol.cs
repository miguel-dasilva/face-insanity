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
    public Light spotLight;
    public float enemyHearsPlayerRadius;
    public Animator animator;
    private CharController playerController;

    public bool enemyMovement = true;

    public bool isAttacking = false;

    public bool freeze = false;

    [Header("Ink JSON")]

    [SerializeField] private TextAsset inkJSON;

    private bool END = false;

    private bool finalDialogue = false;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<CharController>();
        target = player.GetComponent<Transform>();
        spotLight = GameObject.FindGameObjectWithTag("EnemyLight").GetComponent<Light>();

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
        if (finalDialogue && DialogueManager.GetInstance().dialogueIsPlaying == false)
        {
            END = true;
        }
        if (!freeze)
        {
            if (hp <= 0)
            {

                if (!finalDialogue)
                {
                    Debug.Log("OLE");
                    freeze = true;
                    animator.SetTrigger("GoIdle");
                    finalDialogue = true;
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                }
            }

            if (playerSeen)
            {
                if (distanceToPlayer > sight)
                {
                    spotLight.color = Color.white;
                    playerSeen = false;
                    playerController.playerSeen = false;

                    agent.destination = points[destPoint].position;
                }
                else
                {
                    if (distanceToPlayer <= attackRange)
                    {
                        animator.SetTrigger("Attack");
                        enemyMovement = false;
                        isAttacking = true;
                        StartCoroutine(reEnableEnemyMovement());
                    }
                    else
                    {
                        spotLight.color = Color.red;
                        agent.transform.LookAt(playerPosition);
                        agent.SetDestination(target.position);
                        isAttacking = false;
                    }
                }
                agent.speed = 13.0f;
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


            if (!agent.pathPending && agent.remainingDistance < 0.5f && enemyMovement)
            {
                GotoNextPoint();
            }

        }


    }

    public bool GetEND()
    {
        return END;
    }

    private IEnumerator reEnableEnemyMovement()
    {
        yield return new WaitForSecondsRealtime(5.0f);
        enemyMovement = true;
    }
}
