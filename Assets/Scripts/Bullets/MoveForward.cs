using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

    [SerializeField]
    private float Velocity;
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up * Time.deltaTime * Velocity;
    }
}
