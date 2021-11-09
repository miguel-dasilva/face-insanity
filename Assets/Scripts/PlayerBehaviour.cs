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

    private void Awake()
    {

        playerControls = new InputHandler();
        playerControls.Player.Movement.started += _ => StartMovement();
        playerControls.Player.Movement.canceled += _ => CancelMovement();

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
        if (this.isWalking == true)
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

}


