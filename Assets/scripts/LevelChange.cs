using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public Animator anim;
    private int levelToLoad;
    public static GM instance;
    public AudioSource buttonClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
        
    }

    public void FadeToNextLevel()
    {
        Fade(SceneManager.GetActiveScene().buildIndex + 1);
        buttonClick.Play();
    }


    public void Fade(int level)
    {
        levelToLoad = level;
        anim.SetTrigger("FadeOut");
        
    }

    public void FadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }


}
