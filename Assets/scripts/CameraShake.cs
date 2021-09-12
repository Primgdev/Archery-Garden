using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    
    public static CameraShake instance;
    private float shakeTimeRemaining = 2f, shakePower = 0.7f, shakeFade = 1.0f;
    public Transform cam;

    Vector3 originalPos;

    public void Start()
    {
        instance = this;
        
    }

    private void Awake()
    {

    }
    private void OnEnable()
    {
        originalPos = cam.localPosition;
    }

    IEnumerator Shake()
    {

        print("Shaking");

        float t = 1;
        while(t > 0)
        {
            
            cam.localPosition = originalPos + Random.insideUnitSphere * 0.05f * t;
           // shakeTimeRemaining -= Time.deltaTime * shakeFade;
            t -= Time.deltaTime;
            yield return null;
        }
        
            shakeTimeRemaining = 2f;
        cam.localPosition = Vector3.zero ;
        
    }





    public void StartShake(float lenght, float power)
    {
        shakeTimeRemaining = lenght;
        shakePower = power;

        shakeFade = power / lenght;
        print("shake" + power+ "" + lenght);

        StartCoroutine("Shake");
        
        

    }





}
