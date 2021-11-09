using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;
    CharController character;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        character = GetComponent<CharController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (character.GetIsWalking())
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
