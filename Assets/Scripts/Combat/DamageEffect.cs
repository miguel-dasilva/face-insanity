using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class DamageEffect : MonoBehaviour
{
    public Color[] normalColors;
    public Color damagedColor;
    private GameObject enemy;

    private Renderer[] renderers;
    public float duration;

    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Boss");
        renderers = enemy.GetComponentsInChildren<Renderer>();
        normalColors = new Color[renderers.Length];
        int i = 0;
        foreach (Renderer rend in renderers)
        {
            normalColors[i] = rend.material.color;
            i++;
        }
        damagedColor = new Color(1, 0, 0);
    }
    public void StartDamagedEffect()
    {
        StartCoroutine(DamageEffectRoutine());
    }

    private IEnumerator DamageEffectRoutine()
    {
        float startTime = Time.time;
        float percent = 0;
        int i = 0;


        while (percent < 1)
        {
            percent = (Time.time - startTime) / duration;
            foreach (Renderer rend in renderers)
            {
                rend.material.color = Color.Lerp(normalColors[i], damagedColor, percent);
                i++;
            }
            yield return null;

        }
        startTime = Time.time;
        percent = 0;
        i = 0;
        while (percent < 1)
        {
            percent = (Time.time - startTime) / duration;
            foreach (Renderer rend in renderers)
            {
                rend.material.color = Color.Lerp(damagedColor, normalColors[i], percent);
                i++;
            }
            yield return null;

        }
    }
}
