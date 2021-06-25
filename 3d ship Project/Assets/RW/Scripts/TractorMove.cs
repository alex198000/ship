using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
    private bool mooving;
 


    void Update()
    {
        if( mooving == true)
        {
            if (((transform.position.x >= -22f) && (direction == -1f))  || ((transform.position.x <= 22f) && (direction == 1f)))
               
        {
            transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
        }
            //else if ((transform.position.x <= 22f) && (direction == 1f))
            //{
            //    transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            //}
        }



    }

    public void MoveRight()
    {
        
        direction = 1f;
        mooving = true;
    }
    public void MoveLeft()
    {
        
        direction = -1f;
        mooving = true;
    }
    public void StopMove()
    {
        
        //direction = 0f;
        mooving = false;
    }

}
