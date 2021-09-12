using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level8 : MonoBehaviour
{

    public Transform targetRotateA;
    public Transform targetRotateB;
    float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            targetRotateA.Rotate(new Vector3(0, 0, 5) * speed);
            targetRotateB.Rotate(new Vector3(0, 0, -5) * speed);
        
    }
}
