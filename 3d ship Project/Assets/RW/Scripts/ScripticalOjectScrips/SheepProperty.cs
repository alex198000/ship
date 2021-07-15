using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

