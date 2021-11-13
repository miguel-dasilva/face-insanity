using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainStoryScene1 : MonoBehaviour
{
    [Header("Story Event")]
    [SerializeField] private GameObject first_mask_received;

    // Start is called before the first frame update

    private void Start()
    {
        first_mask_received.SetActive(false);
    }

    private void Update()
    {
        if (DialogueManager.GetInstance().numberOfFinishedDialogueSegments == 1)
        {
            first_mask_received.SetActive(true);
        }
        if (first_mask_received.activeSelf == true)
        {
            if (DialogueManager.GetInstance().continuePressed == true)
            {
                first_mask_received.SetActive(false);
                //load the next scene, whatever it is... it is not number 2 for sure
                SceneManager.LoadScene(2, LoadSceneMode.Single);

            }
        }
    }
}
