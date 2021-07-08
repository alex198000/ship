using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 diraction;
    [SerializeField] private float jumpForce;
    private Rigidbody rb;
    [SerializeField] private GameObject heartEffect;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        transform.Translate(diraction * speed * Time.fixedDeltaTime);
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

         
        if (other.gameObject.tag == "Seno")
        {
            rb.isKinematic = false;
            GetComponent<BoxCollider>().enabled = false;
            rb.AddForce(Vector3.up * jumpForce);
            Destroy(gameObject, 0.5f);
            Destroy(other.gameObject);

            GameObject effect = Instantiate(heartEffect, transform.position, heartEffect.transform.rotation);
            Destroy(effect, 1f);
        }

       
    }

   
    
}
