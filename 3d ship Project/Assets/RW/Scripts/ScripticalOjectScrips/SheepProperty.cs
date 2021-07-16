using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
[CreateAssetMenu(fileName = "SheepProperty", menuName = "ScriptableObjects/NewSheepProperty")]
public class SheepProperty : ScriptableObject
{

    [SerializeField] private string sheepName;
    [SerializeField] private float sheepSpeed;
    [SerializeField] private Vector3 sheepScale;
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
                Debug.Log("¬ы превысили скорость " + SpeedSheep);
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
        //        Debug.Log("¬ы превысили скорость " + SpeedSheep);
        //    }
        //    else
        //    {
        //        sheepSpeed =  value;
        //    }

        //}

    }
    public Vector3 ScaleSheep
    {
        get
        {
            return  sheepScale;
        }
       
    }

}
=======

[CreateAssetMenu(fileName = "SheepProperty" , menuName = "ScriptableObjects/NewSheepProperty")]
public class SheepProperty : ScriptableObject
{

    [SerializeField]private string sheepName;
    [SerializeField] private float sheepSpeed;
    [SerializeField] private Transform sheepSize;
    [SerializeField] private SpriteRenderer sheepColor;

    //public string SheepName
    //{
    //    get
    //    {
    //        return sheepName;
    //    }
    //    set // может не быть
    //    {
    //        sheepName = value;

    //    }

    //}


    public string SheepName 
    { 
        get;
        set;
    }

    public float SpeedSheep 
    { 
        get;
    }

    public string SheepSize 
    { 
        get;
        set;
    }

    public float SpeedColor 
    { 
        get;
    }



}

>>>>>>> 9897fd259f968f0fc48cf518159ba682e4581aec
