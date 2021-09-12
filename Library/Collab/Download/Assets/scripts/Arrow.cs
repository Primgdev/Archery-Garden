using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
   
    public float speed;

    public GameObject hit;
    public GameObject ground;
    public GameObject aim;

    public Rigidbody rigi;
    
    public AudioSource targetHitSound;

   


    






    // Start is called before the first frame update
    void Start()
    {
     rigi = GetComponent<Rigidbody>();
        
     targetHitSound = GetComponent<AudioSource>();

        rigi.AddRelativeForce(new Vector3(0, 0.0001f, 0));
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate (new Vector3(0, speed, 0) * Time.deltaTime);

        transform.Rotate(Vector3.right *  Time.deltaTime);

    }

    public void OnCollisionEnter(Collision collision)
    {

        
       
        

         if(collision.transform.tag == "ground")
        {
           GameObject arrow = Instantiate(ground, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
         
        else
        {
            targetHitSound.Play();
            // GameObject arrow = Instantiate(hit, transform.position, Quaternion.identity);

            CameraShake.instance.StartShake(0.2f, 0.5f);

            speed = 0;
            //rigi.constraints = RigidbodyConstraints.FreezeAll;
            rigi.isKinematic = true;
            GetComponent<Collider>().enabled = false;
            collision.gameObject.SendMessage("Hit");
            Destroy(this.gameObject, 5);


        }
    }

   


}
