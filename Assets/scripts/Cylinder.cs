using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    Renderer renderer;
    public Color originalColor;
    public int points;

    public GameObject myParent;

    bool active;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
        renderer = GetComponent<Renderer>();

    }

    public void Off()
    {
        active = false;
        StartCoroutine("FadeToBlack");
      
    }

    void TellParentToTurnOff()
    {
        myParent.SendMessage("TurnOff");
    }   

    public void Hit()
    {
        if (active)
        {
            StartCoroutine("Flash");
            GM.instance.AddScore(points);
            Invoke("TellParentToTurnOff", 1.4f);
        }

        else
        {
            StartCoroutine("FlashBlack");
        }
    }

    IEnumerator Flash()
    {
        float t = 0f;
        renderer.material.EnableKeyword("_EMISSION");

        while (t < 1)
        {
            t += Time.deltaTime;
            Color temp = Color.Lerp(Color.white, originalColor, t);
            yield return null;
            renderer.material.SetColor("_EmissionColor", temp);
        }

    }


    IEnumerator FadeToBlack()
    {
        float t = 0f;

        renderer.material.EnableKeyword("_EMISSION");

        Color a = renderer.material.color;
        Color b = renderer.material.GetColor("_EmissionColor");


        while (t < 1)
        {
            t += Time.deltaTime;
            Color tempA = Color.Lerp(a, Color.black, t);
            Color tempB = Color.Lerp(a, Color.black, t);
            yield return null;
            renderer.material.color = tempA;

            renderer.material.SetColor("_EmissionColor", tempB);
        }

    }


    IEnumerator FlashBlack()
    {
        float t = 0f;

       renderer.material.EnableKeyword("_EMISSION");

        while (t < 1)
        {
            t += Time.deltaTime;
            Color temp = Color.Lerp(Color.white, Color.black, t);
            yield return null;
            renderer.material.SetColor("_EmissionColor", temp);
        }

    }
}
