using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidShadow : MonoBehaviour {

    public Transform objectA;
    public Transform objectB;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Make ObjectA's position match objectB
        objectA.position = objectB.position;

        //Now parent the object so it is always there
        //objectA.parent = objectB;
    }
}
