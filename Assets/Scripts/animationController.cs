using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;
    CharController character;

    int WalkingHash;
    int RunningHash;
    int VelocityHash;
    int CrouchingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        character = GetComponent<CharController>();

        WalkingHash = Animator.StringToHash("isWalking");
        RunningHash = Animator.StringToHash("isRunning");
        VelocityHash = Animator.StringToHash("Velocity");
        CrouchingHash = Animator.StringToHash("isCrouched");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool("isRunning");
        bool isWalking = animator.GetBool("isWalking");
        bool isCrouched = animator.GetBool("isCrouched");

        if (!isWalking && character.GetIsWalking())
        {
            animator.SetBool(WalkingHash, true);
        }
        
        if (isWalking && !character.GetIsWalking())
        {
            animator.SetBool(WalkingHash, false);
        }

        if (!isRunning && (character.GetIsWalking() && character.GetIsRunning()))
        {
            animator.SetBool(RunningHash, true);
        }
        
        if (isRunning && (!character.GetIsWalking() || !character.GetIsRunning()))
        {
            animator.SetBool(RunningHash, false);
        }
        
        if (!isCrouched && character.GetIsCrouching())
        {
            animator.SetBool(CrouchingHash, true);
        }

        if (isCrouched && !character.GetIsCrouching())
        {
            animator.SetBool(CrouchingHash, false);
        }

       animator.SetFloat(VelocityHash, character.GetSpeed());
    }
}
