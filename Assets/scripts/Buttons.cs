using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    GameObject text;
    public AudioSource buttonClick;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
   public void Update()
    {
        Destroy(text, 10);
      
    }

    

    public void Next()
    {
        
    }

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // to change next level each time

    

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // to start same level where you end up
        buttonClick.Play();
    }


   

   
}

