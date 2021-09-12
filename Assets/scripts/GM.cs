using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public int score;

    public static GM instance;

    public Text countScore;
    public Text animationScore;
   
    public GameObject star1;
    public GameObject star1bg;
    public GameObject star2;
    public GameObject star2bg;
    public GameObject star3;
    public GameObject star3bg;

    public GameObject s1;
    public GameObject s1bg;
  
    public GameObject s2;
    public GameObject s2bg;
    
    public GameObject s3;
    public GameObject s3bg;
    

    public Animator popup;

    public AudioSource starpop;

    public GameObject nextLevel;
    public GameObject restart;

    public Slider fill;

    int stars = 0;


    void Awake()
    {
        instance = this;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        animationScore.enabled = false;
        fill.value = 0;

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int points)
    {
        animationScore.enabled = true;
        score += points;
        countScore.text = "" +score.ToString();

        fill.value += points;
        
      
        if(score >= 9 && s1.activeSelf == false)
        {
            s1.SetActive(true);
            s1bg.SetActive(false);
            starpop.pitch = 0.95f;
            starpop.Play();

        }

        if(score >= 15 && s2.activeSelf == false)
        {

            s2.SetActive(true);
            s2bg.SetActive(false);
            starpop.pitch = 1f;
            starpop.Play();

        }

        if(score >= 25 && s3.activeSelf == false)
        {
            s3.SetActive(true);
            s3bg.SetActive(false);

            starpop.pitch = 1.05f;
            starpop.Play();
        }

        


        if (points == 1)
        {
            animationScore.color = Color.cyan;
            
        }
        if (points == 3)
        {
            animationScore.color = Color.red;

        }

        if (points == 5)
        {
            animationScore.color = Color.yellow;

        }

        animationScore.text = points.ToString();
        Invoke("DisableText", 2f);

        StartCoroutine(EndScene());

        print("score is "+ score + " and points is" + points  );
    }

    public void Playpopup()

    {
        popup.Play("popup", 0, 0);

    }

    IEnumerator EndScene()
    {
        



        if (score > 9)
        {
            
            star1.SetActive(true);
            star1bg.SetActive(false);
            stars++;


        }
        yield return new WaitForSeconds(1);


        if (score >= 15)
        {
           
            star2.SetActive(true);
            star2bg.SetActive(false);
            stars++;

        }

        yield return new WaitForSeconds(1);

        if (score >= 25)
        {
            
            star3.SetActive(true);
            star3bg.SetActive(false);
            stars++;

        }

        if(score < 9)
        {
            restart.SetActive(true);
            nextLevel.SetActive(false);
        }

        if(score > 9)
        {
            restart.SetActive(true);
            nextLevel.SetActive(true);

            Scene scene = SceneManager.GetActiveScene();
            int levelNumber = int.Parse(scene.name);




            if (levelNumber + 1 > PlayerPrefs.GetInt("Levelunlocked"))
            {


                PlayerPrefs.SetInt("Levelunlocked", levelNumber + 1);
            }

             
            PlayerPrefs.SetInt("Level" + levelNumber, stars );

        }


       


    }

    void DisableText()
    {
        animationScore.enabled = false;
    }
    

   

   


}
