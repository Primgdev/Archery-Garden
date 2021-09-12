using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LM : MonoBehaviour
{
    public Button[] lvlbtn;



    // Start is called before the first frame update
    void Start()
    {
        

        int howmuch = PlayerPrefs.GetInt("Levelunlocked");

        for(int a = 0; a < howmuch; a++)
        {
            lvlbtn[a].interactable = true;
            lvlbtn[a].transform.Find("stars").gameObject.SetActive(true);

            int stars = PlayerPrefs.GetInt("Level" + (a + 1));

            if(stars > 9)
            {
                lvlbtn[a].transform.Find("stars/s1").gameObject.SetActive(true);

            }
            if(stars > 5)
            {
                lvlbtn[a].transform.Find("stars/s2").gameObject.SetActive(true);
            }
            if(stars > 25)
            {
                lvlbtn[a].transform.Find("stars/s3").gameObject.SetActive(true);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
