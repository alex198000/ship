using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWavews : MonoBehaviour
{

    [SerializeField] private GameObject Enemy;
    [SerializeField] private Vector3 spawnValues;
    [SerializeField] private int count;
    [SerializeField] private float spawnRate;
    [SerializeField] private Transform SheepManager;
    [SerializeField] private Vector3 spawnPointPosition;
    [SerializeField] private Vector2 boundary;
    [SerializeField] private float srartWave;
    [SerializeField] private float waveWait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(srartWave);
        while (true)
        {


            for (int i = 0; i <= count; i++)
            {


                float xRandom = Random.Range(boundary.x, boundary.y);
                spawnPointPosition = new Vector3(xRandom, spawnPointPosition.y, spawnPointPosition.z);
                GameObject Enemy = Instantiate(this.Enemy, spawnPointPosition, this.Enemy.transform.rotation);
                Enemy.transform.SetParent(SheepManager);


                yield return new WaitForSeconds(Random.Range(0.5f, spawnRate));
            }

            yield return new WaitForSeconds(waveWait);
        }
    }
}
