using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float thrust;

    [SerializeField]
    private float dodgeThrust;

    [SerializeField]
    private float reverseThrust;

    public Rigidbody rb;


    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        // DIRECT MOVEMENT
        //if (Input.GetKey(KeyCode.D))
        //{
        //    Debug.Log("forward");
        //    transform.Translate(Vector3.right * Time.deltaTime * speedForward);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    Debug.Log("backwards");
        //    transform.Translate(Vector3.left * Time.deltaTime * speedBackward);
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    Debug.Log("forward");
        //    transform.Translate(Vector3.up * Time.deltaTime * dodgeSpeed);
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    Debug.Log("backwards");
        //    transform.Translate(Vector3.down * Time.deltaTime * dodgeSpeed);
        //}



    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * dodgeThrust);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * reverseThrust);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.up * dodgeThrust);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * thrust);
        }

            rb.velocity = rb.velocity * 0.9f;
    }
}
