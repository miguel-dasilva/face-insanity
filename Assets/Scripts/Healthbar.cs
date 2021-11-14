using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
    // Start is called before the first frame update
    public Image HealthBar;
    public float currentHealth;
    private float maxHealth;

    CharController Player;
    void Start()
    {
        HealthBar = GetComponent<Image>();
        Player = FindObjectOfType<CharController>();
        maxHealth = Player.maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = Player.hp;
        HealthBar.fillAmount = currentHealth / maxHealth;

    }
}
