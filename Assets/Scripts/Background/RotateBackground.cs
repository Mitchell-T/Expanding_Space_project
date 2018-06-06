using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackground : MonoBehaviour {

    [SerializeField]
    private GameObject[] images;

    [SerializeField]
    private float[] speed;

    private void Update()
    {
        for (int i=0; i < images.Length; i++)
        {
            images[i].transform.Rotate(0, 0, speed[i]);
        }
    }

}
