using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/SheepsManager")]
public class SheepManager : ScriptableObject
{
    [SerializeField] private GameObject SheepLow;
    [SerializeField] private GameObject SheepMedium;
    [SerializeField] private GameObject SheepHigh;

    [SerializeField] private GameObject enemy;

    private void ChoiceSheep(GameObject sheepEnemy)
    {

        enemy = GameObject.FindGameObjectWithTag("Enemy");
        //enemy.GetComponent<Rigidbody>();
    }

    public void ChoiceSheepLow()
    {
        ChoiceSheep(SheepLow);
    }

    public void ChoiceSheepMedium()
    {
        ChoiceSheep(SheepMedium);
    }

    public void ChoiceSheepHigh()
    {
        ChoiceSheep(SheepHigh);
    }
}
