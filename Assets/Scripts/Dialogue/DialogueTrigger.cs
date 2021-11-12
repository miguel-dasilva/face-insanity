using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [Header("Sit Position")]
    [SerializeField] private Transform sitPosition;

    private PlayerBehaviour Player;
    private CharController PlayerController;
    private Rigidbody playerRB;
    private Animator animator;
    private Animator playerAnim;

    bool playerInRange = false;
    bool interactDismissed = false;

    private void Awake()
    {
        visualCue.SetActive(false);
    }

    private void Start()
    {
        animator = visualCue.GetComponent<Animator>();
        playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();
        PlayerController = GameObject.FindGameObjectWithTag("Player").GetComponent<CharController>();
        playerRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();

    }

    private void Update()
    {
        if (playerInRange)
        {
            if (interactDismissed == false)
            {
                visualCue.SetActive(true);
                visualCue.transform.LookAt(Camera.main.transform.position);

            }

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
        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }



}
