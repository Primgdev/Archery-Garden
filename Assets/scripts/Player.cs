using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Touch touch;
    public Animator anim;
    public GameObject respawnArrow;
    public GameObject arrow;
    public float movement;
    public int countArrow = 5;
    public GameObject capsule;
    public GameObject yaxis ;
    private float nextArrow = 0;
    private float fireRate = 2;
    public Animator arrowPull;
    public  GameObject endScene;
    public Text arrowLeft;

    public AudioSource win;
    public AudioSource music;
    public AudioSource pull;
    public AudioSource release;
    public Animator ArrowUI;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        win = GetComponent<AudioSource>();

        music.Play();

        StartCoroutine(Endscene());

    }

    // Update is called once per frame
    void Update()
    {

        
        if (countArrow > 0)
        {
            


            if (Input.touchCount == 1)
            {

                
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began )
                {
                    anim.SetBool("Draw", true);
                    arrowPull.SetBool("arrowPull", true);
                    pull.Play();

                    //anim.SetTrigger("Shoot");

                }

                else if (touch.phase == TouchPhase.Moved)
                {
                    // transform.Rotate = new Vector3(transform.position.x + touch.deltaPosition.x * movement,
                    //  transform.position.y + touch.deltaPosition.y * movement);
                    if (capsule.transform.rotation.y > -0.3f && touch.deltaPosition.x < 0)
                    {
                        capsule.transform.Rotate(new Vector3(0, touch.deltaPosition.x, 0) * Time.deltaTime);
                       

                    }
                    else if (capsule.transform.rotation.y < 0.3f && touch.deltaPosition.x > 0)
                    {
                        capsule.transform.Rotate(new Vector3(0, touch.deltaPosition.x, 0) * Time.deltaTime);
                       
                    }

                    
                        yaxis.transform.Rotate(new Vector3(-touch.deltaPosition.y, 0, 0) * Time.deltaTime);

                    

                   

                    



                }
                
                else if (touch.phase == TouchPhase.Ended && Time.time > nextArrow)
                    {
                   

                    nextArrow = Time.time + fireRate;
                        Instantiate(arrow, respawnArrow.transform.position, respawnArrow.transform.rotation);
                        //anim.SetTrigger("Shoot");
                        anim.SetBool("Draw", false);
                    arrowPull.SetBool("arrowPull", false);
                    arrowPull.gameObject.SetActive(false);
                    Invoke("ShowArrow", 2f);
                    ArrowUI.Play("ArrowUI", 0, 0);
                    countArrow -= 1;
                    release.Play();
                    arrowLeft.text = countArrow.ToString();
                    //ArrowUI.SetTrigger("Arrow");
                    // capsule.transform.localRotation = Quaternion.identity;




                }

            }

        }


      

       
        

    }

    IEnumerator Endscene()
    {
          while (countArrow > 0)
        {
            yield return new WaitForSecondsRealtime(1);
            
           
        }

        yield return new WaitForSeconds(5);

        endScene.SetActive(true);
        win.Play();
    }




    void ShowArrow()
    {
        
        arrowPull.gameObject.SetActive(true);
    }
}