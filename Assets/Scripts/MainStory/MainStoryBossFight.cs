using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class MainStoryBossFight : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Story Event")]
    [SerializeField] private GameObject panel_communicate_message;

    [Header("Image")]

    [SerializeField] private RawImage image;

    [Header("Game Over Image")]

    [SerializeField] private RawImage gameOverImage;

    [Header("Text")]

    [SerializeField] private TextMeshProUGUI text;

    private bool playerDead = false;





    private CharController playerCharacter;

    void Start()
    {
        panel_communicate_message.SetActive(false);
        gameOverImage.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
        playerCharacter = FindObjectOfType<CharController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDead)
        {
            if (DialogueManager.GetInstance().continuePressed)
            {
                SceneManager.LoadScene(3, LoadSceneMode.Single);
            }
        }
        if (playerCharacter.hp <= 0)
        {
            text.SetText("You died. Click Enter to Respawn...");
            gameOverImage.gameObject.SetActive(true);
            panel_communicate_message.SetActive(true);
            playerDead = true;

        }
    }
}
