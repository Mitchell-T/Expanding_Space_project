using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField]
    private Rigidbody smallEnemy;
    [SerializeField]
    private Rigidbody mediumEnemy;
    [SerializeField]
    private Rigidbody largeEnemy;
    [SerializeField]
    private Rigidbody Boss;
    [SerializeField]
    private Rigidbody asteroid;

    private void Start()
    {
        SpawnSmallEnemies();
    }


    public void SpawnSmallEnemies()
    {
        Spawn(smallEnemy, 10, 6.2f, -4.2f);
    }

    public void SpawnMediumEnemies()
    {

    }

    public void SpawnLargeEnemies()
    {

    }

    public void SpawnBoss()
    {

    }

    public void SpawnAsteroid()
    {
        
    }

    private void Spawn(Rigidbody enemyToSpawn, int numberToSpawn, float maxTopCoord, float maxBottomCoord)
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            Instantiate(enemyToSpawn, new Vector3(11, Random.Range(maxBottomCoord, maxTopCoord), 0), Quaternion.identity);
        }
    }
}
