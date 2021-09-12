using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public AudioSource buttonClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1()
    {
        SceneManager.LoadScene(1);
        buttonClick.Play();
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
        buttonClick.Play();
    }
    public void Level3()
    {
        SceneManager.LoadScene(3);
        buttonClick.Play();
    }
    public void Level4()
    {
        SceneManager.LoadScene(4);
        buttonClick.Play();
    }
    public void Level5()
    {
        SceneManager.LoadScene(5);
        buttonClick.Play();
    }
    public void Level6()
    {
        SceneManager.LoadScene(6);
        buttonClick.Play();
    }
    public void Level7()
    {
        SceneManager.LoadScene(7);
        buttonClick.Play();
    }
    public void Level8()
    {
        SceneManager.LoadScene(8);
        buttonClick.Play();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
        buttonClick.Play();
    }
}
