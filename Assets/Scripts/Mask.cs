using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Mask : MonoBehaviour
{
    // Start is called before the first frame update
    public Dictionary<string, bool> loadout;

    [Header("Equiped Mask")]
    [SerializeField] public GameObject equipedMask;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;

    public int num_choices = 2;
    private bool maskChanged = false;

    public bool tab_pressed = false;
    void Start()
    {
        loadout = new Dictionary<string, bool>();

        UpdateMaskLoadout();
        DisplayChoices(1);


    }

    // Update is called once per frame
    void Update()
    {
        if (tab_pressed)
        {
            DisplayChoices(choices.Length);
        }
        else
        {
            DisplayChoices(1);
        }
        if (maskChanged)
        {
            UpdateMaskLoadout();
            maskChanged = !maskChanged;
        }
    }

    public void ChangeEquipedMask(GameObject newMask)
    {
        equipedMask = newMask;
        maskChanged = true;
    }

    private void UpdateMaskLoadout()
    {

        if (equipedMask.tag == "stealthMask")
        {
            loadout.Clear();
            loadout.Add("crouch", true);
            loadout.Add("tamper", true);
            loadout.Add("choke", true);
        }
        else if (equipedMask.tag == "meleeMask")
        {
            loadout.Clear();
            loadout.Add("brawl", true);
        }
        else
        {
            loadout.Clear();
        }

    }


    private void DisplayChoices(int num_to_be_displayed)
    {

        int ind;
        if (num_to_be_displayed == 1)
        {
            foreach (GameObject choice in choices)
            {
                if (choice.tag == equipedMask.tag)
                {
                    choice.SetActive(true);
                }
                else
                {
                    choice.SetActive(false);
                }
            }
        }
        else
        {
            for (ind = 0; ind < num_to_be_displayed; ind++)
            {
                choices[ind].gameObject.SetActive(true);
            }

            for (int i = ind; i < choices.Length; i++)
            {
                choices[i].gameObject.SetActive(false);
            }

        }
        StartCoroutine(SelectFirstChoiceEvent());


    }

    private IEnumerator SelectFirstChoiceEvent()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);

    }
}
