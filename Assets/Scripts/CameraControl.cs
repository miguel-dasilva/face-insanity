using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Player")]
    [SerializeField] private GameObject player;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = player.transform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;
    }

    void MoveCamera(Vector3 movement)
    {
        this.transform.position += movement;
    }
}
