using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    [SerializeField]
    private GameObject[] waves;

    [SerializeField]
    private float[] timeAfterWave;

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

            yield return new WaitForSeconds(timeAfterWave[i]);
        }
    }

}
