using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Target : MonoBehaviour
{

    
   public GameObject result;
    GameObject mainCam;

  


    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main.gameObject;
    
    }


    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "arrow" )
        {
            
          StartCoroutine(switchCamera());
            

        }

    }

   



        

IEnumerator switchCamera()
    {
        //yield return new WaitForSeconds(0f);
       
        mainCam.SetActive(false);
        result.SetActive(true);
        CameraShake.instance.cam = result.transform;
        CameraShake.instance.StartShake(0.01f, 0.01f);
    


        yield return new WaitForSeconds(2f);
        mainCam.SetActive(true);
        result.SetActive(false);
       

    }
}
