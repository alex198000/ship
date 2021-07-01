using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenoMoovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 diraction;


    void FixedUpdate()
    {
        transform.Translate(diraction * speed * Time.fixedDeltaTime);
    }


}
