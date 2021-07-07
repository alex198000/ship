using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JampShepp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().isKinematic = false;
        other.GetComponent<Rigidbody>().useGravity = false;
    }
}
