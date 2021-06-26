using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//public enum StudentsAge : int
//{
//    AleksandrK = 40,
//    AlexR = 31,
//    Veron = 14
//}


public enum AffairsOfTheWeeks : int
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public enum Moovet : int
{
    Moove = 1,
    Stop = 0
}



public class TestMoove : MonoBehaviour
{

    
    [SerializeField] private float speed = 20;
    private float direction;
    

    AffairsOfTheWeeks affairsOfTheWeeks;
    Moovet moovet;





   

    void Update()
    {
        if (moovet != Moovet.Stop)
        {
            if (((transform.position.x >= -22f) && (direction == -1f)) || ((transform.position.x <= 22f) && (direction == 1f)))

            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }
           
        }



    }

    public void MoveRight()
    {
        moovet = Moovet.Moove;
        int a = (int)moovet;
        direction = 1f;
       
    }
    public void MoveLeft()
    {
        moovet = Moovet.Moove;
        int a = (int)moovet;
        direction = -1f;
       
    }
    public void StopMove()
    {
        moovet = Moovet.Stop;
      
    }





}
