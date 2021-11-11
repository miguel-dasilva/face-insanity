using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
//using UnityEngine.InputSystem;


public class PlayerBehaviour : MonoBehaviour
{
    private InputHandler playerControls;
    private CharController character;

    private bool isWalking = false;
    private bool isSprinting = false;
    private bool isCrouched = false;

    private void Awake()
    {

        playerControls = new InputHandler();
        playerControls.Player.Movement.started += _ => StartMovement();
        playerControls.Player.Movement.canceled += _ => CancelMovement();

        playerControls.Player.SprintPressed.performed += _ => SprintPressed();
        playerControls.Player.SprintReleased.performed += _ => SprintReleased();

        playerControls.Player.CrouchPressed.performed += _ => CrouchPressed();
        playerControls.Player.CrouchReleased.performed += _ => CrouchReleased();

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
        if (this.isWalking)
        {
            character.Move(playerControls.Player.Movement.ReadValue<Vector2>());
        }
    }

    private void StartMovement()
    {
        isWalking = true;
        character.SetIsWalking(true);
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
        isCrouched = true;
        character.SetIsCrouching(true);
    }
    private void CrouchReleased()
    {
        isCrouched = false;
        character.SetIsCrouching(false);
    }

}


