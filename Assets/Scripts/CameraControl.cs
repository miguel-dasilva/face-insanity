using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Player")]
    [SerializeField] private GameObject player;

    public float smoothSpeed = 0.125f;

    private CharController character;

    public Vector3 offset;

    private float shake = 0;

    public float shakeAmount = 0.7f;

    public float decreaseFactor = 1.0f;
    void Start()
    {
        character = player.GetComponent<CharController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shake > 0)
        {
            transform.localPosition += Random.insideUnitSphere * shakeAmount;
            shake -= Time.deltaTime * decreaseFactor;

        }
        else
        {
            shake = 0.0f;
        }
    }

    private void LateUpdate()
    {
        if (character.hp > 0)
        {
            Vector3 desiredPosition = player.transform.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothPosition;
        }

    }

    void MoveCamera(Vector3 movement)
    {
        this.transform.position += movement;
    }

    public void Shake(int value)
    {
        shake = value;
    }
}
