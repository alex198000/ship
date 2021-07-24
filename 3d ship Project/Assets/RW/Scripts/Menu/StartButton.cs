using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour, IPointerClickHandler
{


    [SerializeField] private Animator animator;



    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(StartGame());
    }
        IEnumerator StartGame()
        {
        animator.SetTrigger("Start");
        
        yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // SceneManager.LoadScene(1);
        }
}
