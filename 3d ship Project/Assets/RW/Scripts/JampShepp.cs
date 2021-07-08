using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JampShepp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().isKinematic = false;
        other.GetComponent<Rigidbody>().useGravity = false;
        //other.GetComponent<Transform>().position = new Vector3(0f, 4f, 0f) * Time.deltaTime;
        
    
    // other.gameObject.transform.position.y = new Vector3.up;
    
     }
}
