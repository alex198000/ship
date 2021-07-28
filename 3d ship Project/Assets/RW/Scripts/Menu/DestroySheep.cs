using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroySheep : MonoBehaviour
{
    [SerializeField] private Animator animator;



    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(StartDestroySheep());
    }
    IEnumerator StartDestroySheep()
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(5.5f);
        
    }
}
