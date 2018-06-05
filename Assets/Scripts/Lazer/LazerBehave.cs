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

        Vector3 bulletpos = (transform.position + new Vector3(1, 0, 0));

        //Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, transform.rotation);
        //bulletClone.velocity = transform.right * bulletSpeed;
        //Physics.IgnoreCollision(bulletClone.GetComponent<Collider>(), GetComponent<Collider>(), true);
        //FindObjectOfType<AudioManager>().Play("c1");

        //Make ObjectA's position match objectB
        Vector3 objectA = (transform.position + new Vector3(xx, yy,0));
        //lazerWidth += Time.deltaTime * lazerWidthSpeed;
        //transform.localScale = new Vector3(lazerWidth, 1, 1);
        //Sprite.
        //transform.position += transform.up * Time.deltaTime * Velocity;
    }
}
