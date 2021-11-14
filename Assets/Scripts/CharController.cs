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
    private float acceleration = 8.0f;
    private float deceleration = 10.0f;
    private float maxSpeed = 6.5f;

    private bool isRunning = false;
    private float runSpeed = 17.0f;

    private bool isCrouched = false;
    private float crouchHeight = 1.25f;
    private float crouchSpeed = 6.0f;

    public bool playerSeen = false;


    public bool isHidden;

    private Mask mask;

    private bool isColliding = false;
    // Start is called before the first frame update

    public float hp;
    public float maxHp = 100f;
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        characterBody = GetComponent<Rigidbody>();
        hp = maxHp;
        isHidden = false;
        mask = GetComponent<Mask>();


    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            this.gameObject.transform.SetPositionAndRotation(new Vector3(0, -200, 0), this.gameObject.transform.rotation);

        }
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
            moveSpeed = 0.01f;
        }
        if (isCrouched)
        {
            deceleration = 40.0f;
        }
        else
        {
            deceleration = 10.0f;
        }
        if (isColliding && moveSpeed > 3f)
        {
            moveSpeed = 3f;
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
            if (isCrouched)
                StartCoroutine(ChangeAccelarationAfterOtherAction(1f, 8.0f, deceleration, runSpeed));
            else
                maxSpeed = runSpeed;
        }
        else
        {
            maxSpeed = 6.5f;
        }
        isRunning = value;
        if (value)
            isCrouched = false;

    }
    public bool GetIsRunning() { return isRunning; }
    public void SetIsCrouching(bool value)
    {
        if (value && mask.loadout.ContainsKey("crouch"))
        {
            maxSpeed = crouchSpeed;
        }
        else if (mask.loadout.ContainsKey("crouch"))
        {
            maxSpeed = 0.1f;
            acceleration = 0.0f;
            StartCoroutine(ChangeAccelarationAfterOtherAction(0.6f, 8.0f, deceleration, 6.5f));
        }
        if (mask.loadout.ContainsKey("crouch"))
        {
            isCrouched = value;
            if (playerSeen == false && isCrouched)
            {
                isHidden = true;
            }
            else
            {
                isHidden = false;
            }
            if (value)
                isRunning = false;

        }
    }
    public bool GetIsCrouching() { return isCrouched; }
    public float GetSpeed() { return moveSpeed; }

    public void SetPosition(Vector3 snapPosition, Quaternion snapRotation)
    {
        transform.SetPositionAndRotation(snapPosition, snapRotation);
    }

    private IEnumerator ChangeAccelarationAfterOtherAction(float time, float accelaratione, float deccelaratione, float max_speed)
    {
        yield return new WaitForSecondsRealtime(time);
        acceleration = accelaratione;
        maxSpeed = max_speed;
        deceleration = deccelaratione;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boss")
        {
            this.hp -= 20;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            isColliding = true;
        }
        // substituir isto por um script a serio que possa ser replicavel

        //------------------------------------------------
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Wall")
            isColliding = false;
    }
}