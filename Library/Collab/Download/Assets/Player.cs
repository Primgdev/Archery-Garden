using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Touch touch;
    public Animator anim;
    public GameObject respawnArrow;
    public GameObject arrow;
    public float movement;
    private int countArrow = 5;
    public GameObject capsule;
    public GameObject yaxis ;
    private float nextArrow = 0;
    private float fireRate = 2;
    

    
    





    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
        

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

                    
                        yaxis.transform.Rotate(new Vector3(touch.deltaPosition.y, 0, 0) * Time.deltaTime);

                    

                   

                    



                }
                
                else if (touch.phase == TouchPhase.Ended && Time.time > nextArrow)
                    {

                    nextArrow = Time.time + fireRate;
                        Instantiate(arrow, respawnArrow.transform.position, respawnArrow.transform.rotation);
                        //anim.SetTrigger("Shoot");
                        anim.SetBool("Draw", false);
                    // countArrow -= 1;
                  // capsule.transform.localRotation = Quaternion.identity;


                }

            }

        }
    }
}