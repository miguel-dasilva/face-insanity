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

    public Transform hitPoint;

    protected override void Start()
    {
        base.Start();
        enemy = GameObject.FindGameObjectWithTag("Boss");
        enemyScript = enemy.GetComponent<Patrol>();
        chokeDamage = (enemyScript.hp / 3) + 1;
        damageEffect = GetComponent<DamageEffect>();
        playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

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
        //Debug.Log("ENEMY HP = " + enemyScript.hp);
        //damageEffect.StartDamagedEffect();
        Debug.Log("animation");
        enemyScript.damaged();
        PlayerController.transform.rotation = hitPoint.rotation;
        playerAnim.SetBool("Attacking", true);
        // do animation stuff xD
    }

    private IEnumerator reEnableChoke()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        chokeEnabled = true;
        interactDismissed = false;
        enemyScript.playerSeen = true;
        playerAnim.SetBool("Attacking", false);


    }
}
