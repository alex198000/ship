using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMovement : MonoBehaviour
{
    //[SerializeField] private float speed;
    [SerializeField] private Vector3 diraction;
    [SerializeField] private float jumpForce;
    private Rigidbody rb;
    [SerializeField] private GameObject heartEffect;
    [SerializeField] private SheepProperty sheepProperty;
    [SerializeField] private SoundManager soundManager;

     private SheepProperty sheepProperty;





    private void Awake()
    {
<<<<<<< HEAD
       
=======
        //sheepProperty.SheepColor(Random.Range(1,3));
>>>>>>> 9897fd259f968f0fc48cf518159ba682e4581aec
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
<<<<<<< HEAD
        transform.Translate(diraction * sheepProperty.SpeedSheep * Time.deltaTime);
=======
        transform.Translate(diraction * speed * Time.deltaTime);
>>>>>>> 9897fd259f968f0fc48cf518159ba682e4581aec
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            rb.isKinematic = false;
            //GetComponent<BoxCollider>().enabled = false;
            rb.AddForce(Vector3.up * jumpForce);

        }
        if (other.gameObject.tag == "WaterOff")
        {
            rb.isKinematic = true;
            //GetComponent<BoxCollider>().enabled = true;
            // rb.AddForce(Vector3.forward * speed);
        }

    }

   
    private void OnTriggerEnter(Collider other)
    {
        SenoMoovement senoMoovement = other.GetComponent<SenoMoovement>();
        
        if (senoMoovement != null)                                            //(other.gameObject.tag == "Seno")
        {
            rb.isKinematic = false;
            GetComponent<BoxCollider>().enabled = false;
            rb.AddForce(Vector3.up * jumpForce);
            Destroy(gameObject, 0.5f);
            Destroy(other.gameObject);
            soundManager.PlaySheepHitClip();
            GameObject effect = Instantiate(heartEffect, transform.position, heartEffect.transform.rotation);
            Destroy(effect, 1f);
        }


        TractorMove tractorMove = other.GetComponent<TractorMove>();
        if (tractorMove != null)                                                 //(other.gameObject.tag == "Tractor")
        {
            rb.isKinematic = false;
            GetComponent<BoxCollider>().enabled = false;
            rb.AddForce(Vector3.up * jumpForce);
            Destroy(gameObject, 0.5f);

            soundManager.PlaySheepHitClip();
            GameObject effect = Instantiate(heartEffect, transform.position, heartEffect.transform.rotation);
            Destroy(effect, 1f);
        }
    }

   public void SetPropertyToSheep(SheepProperty sheepProperty)
    {
        this.sheepProperty = sheepProperty;
        transform.localScale = new Vector3(SheepProperty.sheepScale.x, SheepProperty.sheep.y, SheepProperty.sheepsScale.z);
    }
    
}

