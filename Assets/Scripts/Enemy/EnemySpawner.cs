using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField]
    private GameObject[] waves;

    private void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {

        

        for(int i=0; i < waves.Length; i++)
        {
            waves[i].SetActive(true);
            yield return new WaitForSeconds(6);
        }
    }

}
