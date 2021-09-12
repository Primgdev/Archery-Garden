using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
   
    public float speed;
    public GameObject hit;
    public GameObject ground;
    public Rigidbody rigi;
    public GameObject aim;
   
    public AudioSource targetHitSound;









    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
      
        targetHitSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.forward * speed * Time.deltaTime;
        transform.Translate (new Vector3(0, speed, 0) * Time.deltaTime);
        transform.Rotate(Vector3.right *  Time.deltaTime);

    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "target")
        {
            targetHitSound.Play();
            GameObject arrow = Instantiate(hit, transform.position, Quaternion.identity);
            //CameraCode.instance.Follow(arrow);
            
            CameraShake.instance.StartShake(0.2f, 0.5f);
            speed = 0;
            rigi.constraints = RigidbodyConstraints.FreezeAll;
          
            //countText.text = "" + countText.ToString();
            
           
        }
        else if(collision.transform.tag == "ground")
        {
            GameObject arrow = Instantiate(ground, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
