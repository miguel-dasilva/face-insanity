using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.InputSystem;
//using UnityEngine.InputSystem;


public class PlayerBehaviour : MonoBehaviour
{
    private InputHandler playerControls;
    private CharController character;
    public Animator animator;
    //input control variables
    private bool isWalking = false;
    private bool isSprinting = false;
    private bool isCrouched = false;
    private bool interactPressed = false;
    private bool continuePressed = false;





    private void Awake()
    {

        playerControls = new InputHandler();
        playerControls.Player.Movement.started += ctx => StartMovement(ctx);
        playerControls.Player.Movement.canceled += _ => CancelMovement();
        playerControls.Player.Interact.started += _ => StartInteraction();
        playerControls.Player.Interact.canceled += _ => EndInteraction();
        playerControls.Player.Continue.performed += _ => ContinueStarted();
        playerControls.Player.Continue.canceled += _ => ContinueEnded();



        playerControls.Player.SprintPressed.performed += _ => SprintPressed();
        playerControls.Player.SprintReleased.performed += _ => SprintReleased();

        playerControls.Player.CrouchPressed.performed += _ => CrouchPressed();
        // playerControls.Player.CrouchReleased.performed += _ => CrouchReleased();

    }


    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
    private void Start()
    {
        character = GetComponent<CharController>();

    }
    private void Update()
    {
        if (this.isWalking && !animator.GetBool("Attacking"))
        {
            character.Move(playerControls.Player.Movement.ReadValue<Vector2>());
        }
    }

    private void StartMovement(InputAction.CallbackContext ctx)
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying == false)
        {
            isWalking = true;
            character.SetIsWalking(true);
        }
        else
        {

        }
    }

    private void CancelMovement()
    {
        isWalking = false;
        character.SetIsWalking(false);
    }

    private void SprintPressed()
    {
        isSprinting = true;
        character.SetIsRunning(true);
    }
    private void SprintReleased()
    {
        isSprinting = false;
        character.SetIsRunning(false);
    }
    private void CrouchPressed()
    {
        isCrouched = !isCrouched;
        character.SetIsCrouching(isCrouched);
    }
    /*private void CrouchReleased()
    {
        isCrouched = false;
        character.SetIsCrouching(false);
    }*/
    private void StartInteraction() { interactPressed = true; }
    private void EndInteraction() { interactPressed = false; }

    private void ContinueStarted() { DialogueManager.GetInstance().continuePressed = true; }

    private void ContinueEnded() { DialogueManager.GetInstance().continuePressed = false; }

    public bool GetInteractPressed() { return interactPressed; }




}


