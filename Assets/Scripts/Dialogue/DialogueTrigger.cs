using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Triggers;

public class DialogueTrigger : Trigger
{
    // Start is called before the first frame update


    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [Header("Sit Position")]
    [SerializeField] private Transform sitPosition;

    private Animator animator;
    private Animator playerAnim;


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
            animator.SetBool("interactPressed", true);
            playerRB.isKinematic = true;
            PlayerController.SetPosition(sitPosition.position, sitPosition.rotation);
            playerAnim.SetTrigger("Sit");
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
