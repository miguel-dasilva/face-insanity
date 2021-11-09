using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4f;
    [SerializeField] private Rigidbody rb;

    Vector3 forward, right;
    private bool isWalking = false;
    // Start is called before the first frame update
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

    }

    // Update is called once per frame
    void Update()
    {

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
}