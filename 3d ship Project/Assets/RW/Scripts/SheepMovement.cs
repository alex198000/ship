using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SheepMovement : MonoBehaviour
{
    //[SerializeField] private float speed;
    [SerializeField] private Vector3 diraction;
    [SerializeField] private float jumpForce;
    private Rigidbody rb;
    private MeshRenderer mr;
    [SerializeField] private GameObject heartEffect;
    [SerializeField] private SheepProperty sheepProperty;
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private ScoreManager scoreManager;

    //[SerializeField] private UnityEvent shootSheep;

    [SerializeField] private GameEvent savedSheepEvent;


    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {

        transform.Translate(diraction * sheepProperty.SpeedSheep * Time.deltaTime);

        

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

           // shootSheep.Invoke();
            
            rb.isKinematic = false;
            GetComponent<BoxCollider>().enabled = false;
            rb.AddForce(Vector3.up * jumpForce);
            Destroy(gameObject, 0.5f);
            Destroy(other.gameObject);
            soundManager.PlaySheepHitClip();
            GameObject effect = Instantiate(heartEffect, transform.position, heartEffect.transform.rotation);
            Destroy(effect, 1f);


            scoreManager.SaveSheep();
            savedSheepEvent.Raise();
        }


        TractorMove tractorMove = other.GetComponent<TractorMove>();
        if (tractorMove != null)                                                 //(other.gameObject.tag == "Tractor")
        {
            DestroySheep();
        }
    }




     void DestroySheep()
    {
        rb.isKinematic = false;
        GetComponent<BoxCollider>().enabled = false;
        rb.AddForce(Vector3.up * jumpForce);
        Destroy(gameObject, 0.5f);

        soundManager.PlaySheepHitClip();
        GameObject effect = Instantiate(heartEffect, transform.position, heartEffect.transform.rotation);
        Destroy(effect, 1f);

        scoreManager.SaveSheep();

        savedSheepEvent.Raise();
    }



    public void SetPropertyToSheep(SheepProperty sheepProperty)
    {
        this.sheepProperty = sheepProperty;
        transform.localScale = new Vector3(sheepProperty.ScaleSheep, sheepProperty.ScaleSheep, sheepProperty.ScaleSheep);
        mr.material = sheepProperty.SheepColor;



        //Material.Color = sheepProperty.SheepColor;
    }
    
}

