using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Triggers;

public class LightsTrigger : DialogueTrigger
{
    // Start is called before the first frame update



    private Light[] lights;

    private GameObject[] lightsObjects;

    private GameObject enemy;

    private Patrol enemyScript;
    protected override void Start()
    {
        base.Start();
        lightsObjects = GameObject.FindGameObjectsWithTag("HackableLights");
        enemy = GameObject.FindGameObjectWithTag("Boss");
        enemyScript = enemy.GetComponent<Patrol>();
        lights = new Light[lightsObjects.Length];
        int i = 0;
        foreach (GameObject obj in lightsObjects)
        {
            lights[i] = obj.GetComponent<Light>();
            i++;
        }
    }

    protected override void checkForPlayerInteraction()
    {
        if (Player.GetInteractPressed() == true && interactDismissed == false && PlayerController.mask.loadout.ContainsKey("tamper"))
        {
            animator.SetBool("interactPressed", true);
            foreach (Light light in lights)
            {
                light.enabled = false;
            }
            enemyScript.sight -= 15.0f;
            enemyScript.enemyHearsPlayerRadius -= 15.0f;

            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            interactDismissed = true;

        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("PlayerInteracted") && interactDismissed == true)
        {
            animator.SetBool("interactPressed", false);
            visualCue.SetActive(false);
        }
    }





}
