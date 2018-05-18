using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
