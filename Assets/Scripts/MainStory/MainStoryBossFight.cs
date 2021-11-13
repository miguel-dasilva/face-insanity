using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStoryBossFight : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Story Event")]
    [SerializeField] private GameObject panel_communicate_message;

    void Start()
    {
        Debug.Log("ole!");
        panel_communicate_message.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
