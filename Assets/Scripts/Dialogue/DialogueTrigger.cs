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

    private PlayerBehaviour Player;

    private Animator animator;

    bool playerInRange = false;
    bool interactDismissed = false;

    private void Awake()
    {
        visualCue.SetActive(false);
    }

    private void Start()
    {
        animator = visualCue.GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();


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
