using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepDestroyer : MonoBehaviour
{
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private GameEvent droppedSheepEvent;
    [SerializeField] private ScoreManager scoreManager;
    private void OnTriggerExit(Collider other)
    {
        SheepMovement sheepMovement = other.GetComponent<SheepMovement>();
        if(sheepMovement != null)
        {


            soundManager.PlayDropClip();
        other.GetComponent<Rigidbody>().isKinematic = false;
        Destroy(other.gameObject, 3f);


            scoreManager.DropSheep();

            droppedSheepEvent.Raise();
        }
    }
}
