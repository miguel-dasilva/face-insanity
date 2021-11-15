using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Triggers;

public class ChokeTrigger : Trigger
{
    // Start is called before the first frame update

    private GameObject enemy;

    private Patrol enemyScript;

    public float chokeDamage = 34.0f;

    private DamageEffect damageEffect;

    private bool chokeEnabled = true;

    private Animator playerAnim;

    private Rigidbody enemyRb;

    public Transform hitPoint;

    private GameObject spotLight;

    private CameraControl cam;




    protected override void Start()
    {
        base.Start();
        enemy = GameObject.FindGameObjectWithTag("Boss");
        enemyScript = enemy.GetComponent<Patrol>();
        chokeDamage = (enemyScript.hp / 3) + 1;
        damageEffect = GetComponent<DamageEffect>();
        playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        enemyRb = enemy.GetComponent<Rigidbody>();
        spotLight = GameObject.FindGameObjectWithTag("EnemyLight");
        cam = Camera.main.GetComponent<CameraControl>();


    }

    protected override void Update()
    {

        if (playerInRange && enemyScript.playerSeen == false)
        {
            if (interactDismissed == false)
            {
                visualCue.SetActive(true);
                visualCue.transform.LookAt(Camera.main.transform.position);

            }

            checkForPlayerInteraction();

        }
        else
        {
            visualCue.SetActive(false);
        }
    }
    protected override void checkForPlayerInteraction()
    {
        if (Player.GetInteractPressed() == true && interactDismissed == false)
        {
            chokeEnemy();


        }
    }
    private void chokeEnemy()
    {
        if (chokeEnabled)
        {
            enemyScript.hp -= chokeDamage;
            chokeEnabled = false;
            interactDismissed = true;
            StartCoroutine(reEnableChoke());

        }
        PlayerController.transform.rotation = hitPoint.rotation;
        playerAnim.SetBool("Attacking", true);

        enemyRb.transform.position += PlayerController.GetForward() * 10;
        spotLight.SetActive(false);
        StartCoroutine(reEnableLight());
        enemyScript.enemyMovement = false;
        //enemyScript.damaged();
        playerAnim.SetBool("Attacking", false);
        cam.Shake(1);
        // do animation stuff xD
    }

    private IEnumerator reEnableLight()
    {
        yield return new WaitForSecondsRealtime(2.0f);
        spotLight.SetActive(true);
        enemyScript.enemyMovement = true;

    }
    private IEnumerator reEnableChoke()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        chokeEnabled = true;
        interactDismissed = false;
        enemyScript.playerSeen = true;



    }
}
