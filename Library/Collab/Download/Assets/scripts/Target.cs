using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Target : MonoBehaviour
{

    
   public GameObject result;
   public GameObject mainCam;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "arrow")
        {
            
            StartCoroutine(switchCamera());
            
           
        }
       

    }

    IEnumerator switchCamera()
    {
        yield return new WaitForSeconds(0.01f);
       
        mainCam.SetActive(false);
        result.SetActive(true);
       



        yield return new WaitForSeconds(2f);
        mainCam.SetActive(true);
        result.SetActive(false);
       

    }
}
