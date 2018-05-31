using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBehave : MonoBehaviour {


    [SerializeField]
    private float lazerWidthSpeed = 10f;
    [SerializeField]
    private float lazerWidth = 0;

    [SerializeField]
    private Transform objectA;
    [SerializeField]
    private Transform objectB;



    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        float xx = objectB.position.x;
        float yy = objectB.position.y;

        //Make ObjectA's position match objectB
        Vector2 objectA = new Vector2(xx, yy);
        lazerWidth += Time.deltaTime * lazerWidthSpeed;
        transform.localScale = new Vector3(lazerWidth, 1, 1);
        //Sprite.
        //transform.position += transform.up * Time.deltaTime * Velocity;
    }
}
