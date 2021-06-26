using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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


public class TestTractor : MonoBehaviour
{
    [SerializeField] private float speed = 20;
    private float direction;
    //private bool mooving;

    AffairsOfTheWeeks affairsOfTheWeeks;
    Moovet moovet;

    void Update()
    {
        if (moovet != Moovet.Stop)
        {
            if (((transform.position.x >= -22f) && (moovet == Moovet.Moove))) //|| ((transform.position.x <= 22f) && (moovet == Moovet.Moove)))

            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }
            else if (((transform.position.x <= 22f) && (moovet == Moovet.Moove)))
            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }
        }



    }

    public void MoveRight()
    {
        //moovet = Moovet.Moove;
        //int a = (int)moovet;
        direction = 1f;
        //mooving = true;
    }
    public void MoveLeft()
    {
        //moovet = Moovet.Moove;
        //int a = (int)moovet;
        direction = -1f;
        //mooving = true;
    }
    public void StopMove()
    {
        //moovet = Moovet.Stop;
        //int a = (int)moovet;
        direction = 0f;
        ////mooving = false;
    }
    public void Poned()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Monday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        print(affairsOfTheWeeks);
        print("День недели " + a + " : Посетить зоопарк");

    }

    public void Vtorn()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Tuesday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        print(affairsOfTheWeeks);
        print("День недели " + a + " : Посетить курсы");

    }

    public void Srerda()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Wednesday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        print(affairsOfTheWeeks);
        print("День недели " + a + " : Посетить cпортзал");

    }

    public void Chetverg()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Thursday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        print(affairsOfTheWeeks);
        print("День недели " + a + " : Посетить бассейн");

    }

    public void Pyatniza()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Friday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        print(affairsOfTheWeeks);
        print("День недели " + a + " : Посетить курсы Unity");

    }
    public void Subbota()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Saturday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        print(affairsOfTheWeeks);
        print("День недели " + a + " : Выходной1");

    }
    public void Voskr()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Sunday;// назначить сосотояние
        int a = (int)affairsOfTheWeeks;// получить состояние
        print(affairsOfTheWeeks);
        print("День недели " + a + " : Выходной2");

    }
}
