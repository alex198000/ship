using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenoMoovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 diraction;
    [SerializeField] private GameObject senoEffect;

    void Update()
    {
        transform.Translate(diraction * speed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        SheepMovement sheepMovement = other.GetComponent<SheepMovement>();

        if (sheepMovement != null)                                            //(other.gameObject.tag == "Seno")
        {
            GameObject effect = Instantiate(senoEffect, transform.position, senoEffect.transform.rotation);
            Destroy(effect, 1.5f);
        }
    }
}
