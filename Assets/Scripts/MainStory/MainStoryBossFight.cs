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

    [Header("Prototype Done")]

    [SerializeField] private RawImage prototypeDoneImage;

    [Header("Text")]

    [SerializeField] private TextMeshProUGUI text;

    private bool playerDead = false;

    private Patrol boss;

    private CharController playerCharacter;

    private bool lastPanel = false;

    void Start()
    {
        gameOverImage.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
        playerCharacter = FindObjectOfType<CharController>();
        boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<Patrol>();
        text.SetText("He must be around here somewhere. I should approach carefully.");
        panel_communicate_message.SetActive(true);
        StartCoroutine("waitForSec");
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
        if (boss.GetEND() == true)
        {
            if (lastPanel == false)
            {
                text.SetText("This prototype is over! Thanks for watching!");
                prototypeDoneImage.gameObject.SetActive(true);
                panel_communicate_message.SetActive(true);
                lastPanel = true;

            }
            if (lastPanel == true && DialogueManager.GetInstance().continuePressed)
            {
                panel_communicate_message.SetActive(false);
                SceneManager.LoadScene(0, LoadSceneMode.Single);
            }
        }
    }
    IEnumerator waitForSec()
    {
        yield return new WaitForSeconds(5);
        panel_communicate_message.SetActive(false);
    }
}
