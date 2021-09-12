using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    private Vector3 pos1;
    private Vector3 pos2;
    float speed = 0.2f;

    public Transform pointa;
    public Transform pointb;
    public Transform parent;


    float mytime;

    public bool active;

    public static TargetMovement instance;

    // Start is called before the first frame update
    void Start()
    {
        active = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (active)
        {
            parent.position = Vector3.Lerp(pointa.position, pointb.position, Mathf.PingPong(mytime * speed, 1.0f));
            mytime += Time.deltaTime;
        }



        

      



    }

   public IEnumerator TurnOff()
    {

        
        active = false;
        yield return new WaitForSeconds(2);
        active = true;

    }

}


  

