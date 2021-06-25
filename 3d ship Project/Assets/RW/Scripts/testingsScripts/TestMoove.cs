using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum StudentsAge : int
{
    AleksandrK = 40,
    AlexR = 31,
    Veron = 14
}






public class TestMoove : MonoBehaviour
{

    //модификтор_доступа enum имя : тип
    //{
    //    имя1 = значение1,
    //    имя2 = значение2,
    //}
    StudentsAge studentsAge;
   



    void Start()
    {
        studentsAge = StudentsAge.AlexR;// назначить сосотояние
        int a = (int)studentsAge;// получить состояние
        print(studentsAge);
        print(a);
        if(studentsAge == StudentsAge.Veron)// сравнить состояние
        {

        }

    }

}
