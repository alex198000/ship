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

    public List<Transform> spawPoints;
    [SerializeField] private List<SheepProperty> sheepProperties;
    [SerializeField] private Transform SheepManager;
    [SerializeField] private GameObject sheepPrefab;
    public float timeBetweenWaves = 5f;
    public float waveCountDown;
    public float searchCountDown = 1f;

    private SpawningState state = SpawningState.COUNTING;
    private void Start()
    {
        if (spawPoints.Count == 0)
        {
            Debug.Log("No spawn Position");
        }

        waveCountDown = timeBetweenWaves;
    }

    private void Update()
    {
        if(state == SpawningState.WAITING)
        {
            if (!EnemyLives())
            {
                WaveCompleted();
                return;
            }
            else
            {
                return;
            }
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

    void WaveCompleted()
    {
        Debug.Log("Wave completed");

        state = SpawningState.COUNTING;
        waveCountDown = timeBetweenWaves;

        if(nextWave +1 > waves.Count - 1)
        {
            nextWave = 0;
            Debug.Log("Complete all waves! LOOPING!");
        }
        else
        {
            nextWave++;
        }
        
    }

    bool EnemyLives()
    {
        searchCountDown -= Time.deltaTime;
        if(searchCountDown <= 0f)
        {
            searchCountDown = 1f;
            if (GameObject.FindGameObjectWithTag("Sheep") == null)
            {
                return false;
            }
        }

       
        return true;
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
        

        Transform _sp = spawPoints[Random.Range(0, spawPoints.Count)];
        //Instantiate(_enemy, _sp.position, _sp.rotation);
        GameObject enemy = Instantiate(this.sheepPrefab, _sp.position, this.sheepPrefab.transform.rotation);


        int randomSheepPropertyIndex = Random.Range(0, sheepProperties.Count);

        enemy.GetComponent<SheepMovement>().SetPropertyToSheep(sheepProperties[randomSheepPropertyIndex]);
        enemy.transform.SetParent(SheepManager);
    }

}
