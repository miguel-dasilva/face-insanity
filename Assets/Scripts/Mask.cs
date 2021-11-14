using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    // Start is called before the first frame update
    public Dictionary<string, bool> loadout;

    [Header("Equiped Mask")]
    [SerializeField] private GameObject equipedMask;


    private bool maskChanged = false;
    void Start()
    {
        loadout = new Dictionary<string, bool>();

        UpdateMaskLoadout();
    }

    // Update is called once per frame
    void Update()
    {
        if (maskChanged)
        {
            UpdateMaskLoadout();
            maskChanged = !maskChanged;
        }
    }

    public void ChangeEquipedMask(GameObject newMask)
    {
        equipedMask = newMask;
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

    }

    public void SetMaskChanged(bool value)
    {
        maskChanged = value;
    }
}
