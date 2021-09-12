using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    float speed = 2;
    float tile = 50;
    Vector3 startpos;

    
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()

    {
        transform.localPosition = transform.localPosition + -transform.forward * speed * Time.deltaTime;
        float newPos = Mathf.Repeat(Time.time * speed, tile);
        transform.position = startpos + Vector3.right * newPos;
    }

}

