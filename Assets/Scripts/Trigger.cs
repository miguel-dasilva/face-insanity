using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Triggers
{


    public class Trigger : MonoBehaviour
    {
        // Start is called before the first frame update
        [Header("Visual Cue")]
        [SerializeField] protected GameObject visualCue;

        protected PlayerBehaviour Player;
        protected CharController PlayerController;
        protected Rigidbody playerRB;

        protected bool playerInRange;
        protected bool interactDismissed;

        protected void Awake()
        {
            visualCue.SetActive(false);
        }

        protected virtual void Start()
        {
            playerInRange = false;
            interactDismissed = false;
            Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();
            PlayerController = GameObject.FindGameObjectWithTag("Player").GetComponent<CharController>();
            playerRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();

        }

        protected virtual void Update()
        {
            if (playerInRange)
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

        protected virtual void checkForPlayerInteraction()
        {
        }

        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                // Debug.Log("IN RANGE!!!");
                playerInRange = true;
            }
        }

        protected virtual void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                playerInRange = false;
            }
        }



    }
}
