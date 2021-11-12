using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.0f;
    [SerializeField] public Rigidbody rb;

    Vector3 forward, right;

    private Rigidbody characterBody;


    private bool isWalking = false;
    private float acceleration = 4.0f;
    private float deceleration = 3.0f;
    private float maxSpeed = 3.5f;

    private bool isRunning = false;
    private float runSpeed = 6.0f;

    private bool isCrouched = false;
    private float crouchHeight = 1.25f;
    private float crouchSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        characterBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (this.isWalking && moveSpeed < maxSpeed)
        {
            moveSpeed += Time.deltaTime * acceleration;
        }
        if ((!this.isRunning && this.isWalking) && moveSpeed > maxSpeed)
        {
            moveSpeed -= Time.deltaTime * deceleration;
        }
        if (!this.isWalking && moveSpeed > 0)
        {
            moveSpeed -= Time.deltaTime * deceleration;
        }
        if (moveSpeed < 0)
        {
            moveSpeed = 0;
        }
    }

    public void Move(Vector2 movement)
    {


        Vector3 rightMovement = right * Time.deltaTime * moveSpeed * (movement.x);
        Vector3 upMovement = forward * Time.deltaTime * moveSpeed * (movement.y);
        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
        rb.MovePosition(transform.position);
    }



    public void SetIsWalking(bool value) { isWalking = value; }
    public bool GetIsWalking() { return isWalking; }
    public void SetIsRunning(bool value)
    {
        if (value)
        {
            maxSpeed = runSpeed;
        }
        else
        {
            maxSpeed = 4f;
        }
        isRunning = value;
    }
    public bool GetIsRunning() { return isRunning; }
    public void SetIsCrouching(bool value)
    {
        if (value)
        {
            maxSpeed = crouchSpeed;
        }
        else
        {
            maxSpeed = 4f;
        }
        isCrouched = value;
    }
    public bool GetIsCrouching() { return isCrouched; }
    public float GetSpeed() { return moveSpeed; }
}