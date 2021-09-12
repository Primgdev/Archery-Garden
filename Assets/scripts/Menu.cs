using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject setting;
    public GameObject main;

    public AudioSource buttonClick;
    public AudioSource menuMusic;
  

    // Start is called before the first frame update
    void Start()
    {
        menuMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LevelSelect()
    {

        SceneManager.LoadScene(10);
        buttonClick.Play();
    }

    public void Play()
    {
       
        buttonClick.Play();
        
        SceneManager.LoadScene(1);
      
    }

    public void Setting()
    {
        setting.SetActive(true);
        main.SetActive(false);
        buttonClick.Play();

    }

    public void Quit()
    {
        Application.Quit();
        buttonClick.Play();
    }


}
