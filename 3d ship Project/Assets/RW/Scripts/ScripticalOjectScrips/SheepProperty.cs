using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SheepProperty" , menuName = "ScriptableObjects/NewSheepProperty")]
public class SheepProperty : ScriptableObject
{

    [SerializeField]private string sheepName;
    [SerializeField] private float sheepSpeed;

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


    public string SheepName { get; set; }

    public float SpeedSheep { get; }




}

