using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Triggers;

public class DialogueTrigger : Trigger
{
    // Start is called before the first frame update


    [Header("Ink JSON")]
    [SerializeField] protected TextAsset inkJSON;

    [Header("Sit Position")]
    [SerializeField] protected Transform sitPosition;

    protected Animator animator;
    protected Animator playerAnim;


    private new void Awake()
    {
        visualCue.SetActive(false);
    }

    protected override void Start()
    {
        animator = visualCue.GetComponent<Animator>();
        playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        base.Start();

    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void checkForPlayerInteraction()
    {
        if (Player.GetInteractPressed() == true && interactDismissed == false)
        {
            if (sitPosition != null)
            {

                playerRB.isKinematic = true;
                PlayerController.SetPosition(sitPosition.position, sitPosition.rotation);
                playerAnim.SetTrigger("Sit");
            }
            animator.SetBool("interactPressed", true);
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
