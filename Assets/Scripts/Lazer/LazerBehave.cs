using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBehave : MonoBehaviour {


    [SerializeField]
    private float lazerWidthSpeed = 10f;
    [SerializeField]
    private float lazerWidth = 0;

    [SerializeField]
    public Transform objectA;
    [SerializeField]
    public Transform objectB;



    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        //Make ObjectA's position match objectB
        objectA.position = objectB.position;
        lazerWidth += Time.deltaTime * lazerWidthSpeed;
        transform.localScale = new Vector3(lazerWidth, 1, 1);
        //Sprite.
        //transform.position += transform.up * Time.deltaTime * Velocity;
    }
}
