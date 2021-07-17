using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SheepProperty", menuName = "ScriptableObjects/NewSheepProperty")]
public class SheepProperty : ScriptableObject
{

    [SerializeField] private string sheepName;
    [SerializeField] private float sheepSpeed;
    [SerializeField] private float sheepScale;
    //private void OnEnable()
    //{
    //    SpeedSheep = 45f;
    //}
    public string SheepName
    {
        get
        {
            if (sheepName == "")
            {
                return "None Name";
            }
            else
            {
                return sheepName;
            }
           
        }
        set // может не быть
        {
            sheepName = value;

        }

    }


    //public string SheepName { get; }

    //public float SpeedSheep { get { return sheepSpeed; } }

    // public float SheepSpeed => sheepSpeed;

    public float SpeedSheep
    {
        get
        {
            if (sheepSpeed > 30)
            {
                return (Random.Range(1, 20f));
                //Debug.Log("Вы превысили скорость " + SpeedSheep);
            }
            else
            {
                return sheepSpeed;
            }

        }
        //set // может не быть
        //{
        //    if (value > 30)
        //    {
        //        sheepSpeed = (Random.Range(1, 20f));
        //        Debug.Log("Вы превысили скорость " + SpeedSheep);
        //    }
        //    else
        //    {
        //        sheepSpeed =  value;
        //    }

        //}

    }
    public float ScaleSheep
    {
        get
        {
            return  sheepScale;
        }
       
    }

}


