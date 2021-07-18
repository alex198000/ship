using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawnRandom : MonoBehaviour
{
    public enum SpawningState { SPAWNING, WAITING, COUNTING };
    
    
    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;


    }

    public List<Wave> waves;
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountDown;
    private SpawningState state = SpawningState.COUNTING;
    private void Start()
    {
        waveCountDown = timeBetweenWaves;
    }

    private void Update()
    {
        if(state == SpawningState.WAITING)
        {

        }

        if(waveCountDown <= 0)
            {
               if(state != SpawningState.SPAWNING)
            {
                StartCoroutine(SpawnWaves(waves[nextWave]));
            }
            }
        else
        {
            waveCountDown -= Time.deltaTime;
        }
    }


    IEnumerator SpawnWaves(Wave _wave)
    {
        state = SpawningState.SPAWNING;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }
                state = SpawningState.WAITING;
            yield break;
    }
    void SpawnEnemy(Transform _enemy)
    {

    }

}
