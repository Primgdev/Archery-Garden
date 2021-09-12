using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public Renderer renderer;
    public Color originalColor;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit()
    {
        CameraShake.instance.StartShake(0.2f, 0.5f);
        StartCoroutine("Flash");
    }

    IEnumerator Flash()
    {
        float t = 0f;

        while (t < 1)
        {
            t += Time.deltaTime;
            Color temp = Color.Lerp(Color.white, originalColor, t);
            yield return null;
            renderer.material.SetColor("_EmissionColor", temp);
        }

    }
}
