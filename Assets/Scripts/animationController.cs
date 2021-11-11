using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;
    CharController character;
    float velocity;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        character = GetComponent<CharController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool("isRunning");
        bool isWalking = animator.GetBool("isWalking");
        bool isCrouched = animator.GetBool("isCrouched");

        if (!isWalking && character.GetIsWalking())
        {
            animator.SetBool("isWalking", true);
        }
        
        if (isWalking && !character.GetIsWalking())
        {
            animator.SetBool("isWalking", false);
        }

        if (!isRunning && (character.GetIsWalking() && character.GetIsRunning()))
        {
            animator.SetBool("isRunning", true);
        }
        
        if (isRunning && (!character.GetIsWalking() || !character.GetIsRunning()))
        {
            animator.SetBool("isRunning", false);
        }
        
        if (!isCrouched && character.GetIsCrouching())
        {
            animator.SetBool("isCrouched", true);
        }

        if (isCrouched && !character.GetIsCrouching())
        {
            animator.SetBool("isCrouched", false);
        }

       animator.SetFloat("Velocity", character.GetSpeed());
    }
}
