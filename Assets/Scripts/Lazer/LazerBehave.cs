using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBehave : MonoBehaviour {


    [SerializeField]
    private float lazerWidthSpeed = 10f;
    [SerializeField]
    private float lazerWidth = 0;



    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        lazerWidth += Time.deltaTime * 100;
        transform.localScale = new Vector3(lazerWidth, 1, 1);
        //Sprite.
        //transform.position += transform.up * Time.deltaTime * Velocity;
    }
}
