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
    Stop,
    Moove
}



public class TestMoove : MonoBehaviour
{

    
    [SerializeField] private float speed = 20;
    private float direction;
    

    AffairsOfTheWeeks affairsOfTheWeeks;
    Moovet moovet;

    public int result;



   

    void Update()
    {
        if (moovet == Moovet.Moove)
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

    public void Poned()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Monday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        result = a;
        //print(affairsOfTheWeeks);
        //print("День недели " + a + " : Посетить зоопарк");

    }

    public void Vtorn()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Tuesday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        result = a;
        //print(affairsOfTheWeeks);
        //print("День недели " + a + " : Посетить курсы");

    }

    public void Srerda()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Wednesday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        result = a;
        //print(affairsOfTheWeeks);
        //print("День недели " + a + " : Посетить cпортзал");

    }

    public void Chetverg()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Thursday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        result = a;
        //print(affairsOfTheWeeks);
        //print("День недели " + a + " : Посетить бассейн");

    }

    public void Pyatniza()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Friday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        result = a;
        //print(affairsOfTheWeeks);
        //print("День недели " + a + " : Посетить курсы Unity");

    }
    public void Subbota()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Saturday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        result = a;
        //print(affairsOfTheWeeks);
        //print("День недели " + a + " : Выходной1");

    }
    public void Voskr()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Sunday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        result = a;
        //print(affairsOfTheWeeks);
        //print("День недели " + a + " : Выходной2");

    }
    public void Chekk()
    {


        if(result == 1)
        {
            print("Посетить зоопарк");
        }
        else if (result == 2)
        {
            print("Посетить курсы");
        }
        else if (result == 3)
        {
            print("Посетить cпортзал");
        }
        else if (result == 4)
        {
            print("Посетить бассейн");
        }
        else if (result == 5)
        {
            print("Посетить курсы Unity");
        }
        else if (result == 6)
        {
            print("Посетить кинотеатр");
        }
        else if (result == 7)
        {
            print("Выходной");

        }
        else 
        {
            print("Посетить зоопарк");
        }
    }


}
