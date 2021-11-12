using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
public class DialogueManager : MonoBehaviour
{
    private static DialogueManager instance;
    // Start is called before the first frame update
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }
    public bool continuePressed;
    private Animator animator;
    [SerializeField] private GameObject visualCue;

    [Header("Choices UI")]

    [SerializeField] private GameObject[] choices;

    private TextMeshProUGUI[] choicesText;

    private bool isOccupied = false;

    private void Awake()
    {
        if (instance != null)
            Debug.LogWarning("Found more than one instance of a dialogue manager!");
        instance = this;
        dialogueIsPlaying = false;
        continuePressed = false;
    }
    private void Start()
    {
        dialoguePanel.SetActive(false);
        animator = visualCue.GetComponent<Animator>();
        choicesText = new TextMeshProUGUI[choices.Length];
        int ind = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[ind] = choice.GetComponentInChildren<TextMeshProUGUI>();
            ind++;
        }
    }
    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Update()
    {

        if (dialogueIsPlaying == false) return;
        if (continuePressed == true && isOccupied == false)
        {
            isOccupied = true;
            animator.SetBool("NextLine", true);
            StartCoroutine(ContinueStory());
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Pressed"))
        {
            animator.SetBool("NextLine", false);

        }


    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        StartCoroutine(ContinueStory());
    }

    private IEnumerator ContinueStory()
    {
        yield return new WaitForSecondsRealtime(0.5f);

        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
            //aquela programacao defensiva... juro...
            if (dialogueText.text.Equals(""))
            {
                ExitStory();
            }
            else
            {
                DisplayChoices();

            }
        }
        else
        {
            ExitStory();
        }
        isOccupied = false;
    }

    private void ExitStory()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    private void DisplayChoices()
    {

        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.Log("Cant support so many choices (" + currentChoices.Count + ")  in dialogue system (" + choices.Length + ")");
        }

        int ind = 0;

        foreach (Choice choice in currentChoices)
        {
            choices[ind].gameObject.SetActive(true);
            choicesText[ind].text = choice.text;
            ind++;

        }

        for (int i = ind; i < choices.Length; i++)
        {

            choices[i].gameObject.SetActive(false);
        }
        StartCoroutine(SelectFirstChoiceEvent());


    }

    private IEnumerator SelectFirstChoiceEvent()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);

    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
    }
}