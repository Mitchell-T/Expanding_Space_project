using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] waves;

    [SerializeField]
    private float timeInBetweenWaves;

    [SerializeField]
    private int wavesToSpawn;

    private void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        for (int i = 0; i < wavesToSpawn; i++)
        {

            Instantiate(waves[RNG()]);

            yield return new WaitForSeconds(timeInBetweenWaves);
        }
    }

    int RNG()
    {
        int number = Random.Range(0, waves.Length);

        return number;
    }

}
