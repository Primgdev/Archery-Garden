using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    public static CameraShake instance;
    private float shakeTimeRemaining = 0f, shakePower = 0.7f, shakeFade = 1.0f;
    public Transform cam;
    //public float rotation = 10;

    Vector3 originalPos;

    public void Start()
    {
        instance = this;
    }

    private void Awake()
    {
        if(cam == null)
        {
            cam = GetComponent(typeof(Transform)) as Transform;
        }
    }

    private void OnEnable()
    {
        originalPos = cam.localPosition;
    }

    private void Update()
    {
        if(shakeTimeRemaining > 0)
        {
            cam.localPosition = originalPos + Random.insideUnitSphere * shakePower;
            shakeTimeRemaining -= Time.deltaTime * shakeFade;
        }
        else
        {
            shakeTimeRemaining = 0f;
            cam.localPosition = originalPos;
        }
    }


    public void StartShake(float lenght, float power)
    {
        shakeTimeRemaining = lenght;
        shakePower = power;

        shakeFade = power / lenght;

        

    }





}
