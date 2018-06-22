using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addscore : MonoBehaviour
{

    [SerializeField]
    private Rigidbody scoreObject;


    [SerializeField]
    private int scoreToAdd;


    private void OnCollisionEnter(Collision other)
    {
        HitDetect.Score += scoreToAdd;
    }

};