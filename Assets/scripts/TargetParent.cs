using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetParent : MonoBehaviour
{
    public Cylinder red, yellow, blue;
    public Collider targetBox;
   
 

    // Update is called once per frame
    public void TurnOff()
    {
        red.Off();
        blue.Off();
        yellow.Off();
        targetBox.enabled = false;

        
    }
}
