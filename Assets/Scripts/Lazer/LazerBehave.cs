using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBehave : MonoBehaviour {


    [SerializeField]
    private float lazerWidthSpeed = 10f;
    [SerializeField]
    private float lazerWidth = 0;

    
    private GameObject Player;



    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log("Lazer");
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        Vector3 pos = transform.position;

        //float xx = objectB.position.x;
        //float yy = objectB.position.y;

        //Vector3 bulletpos = (transform.position + new Vector3(1, 0, 0));

        pos = Vector3.MoveTowards(pos, Player.transform.position, Mathf.Infinity);
        transform.position = pos;

        //Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, transform.rotation);
        //bulletClone.velocity = transform.right * bulletSpeed;
        //Physics.IgnoreCollision(bulletClone.GetComponent<Collider>(), GetComponent<Collider>(), true);
        //FindObjectOfType<AudioManager>().Play("c1");

        //Make ObjectA's position match objectB
        //Vector3 objectA = (transform.position + new Vector3(xx, yy,0));
        //lazerWidth += Time.deltaTime * lazerWidthSpeed;
        //transform.localScale = new Vector3(lazerWidth, 1, 1);
        //Sprite.
        //transform.position += transform.up * Time.deltaTime * Velocity;
    }
}
