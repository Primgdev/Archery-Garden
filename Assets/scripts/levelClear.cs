using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelClear : MonoBehaviour
{

   
    // Start is called before the first frame update
    public void Pressed()
    {
        
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("Levelunlocked", 1);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
