using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float speedForward;

    [SerializeField]
    private float speedBackward;

    [SerializeField]
    private float dodgeSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("forward");
            transform.Translate(Vector3.right * Time.deltaTime * speedForward);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("backwards");
            transform.Translate(Vector3.left * Time.deltaTime * speedBackward);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("forward");
            transform.Translate(Vector3.up * Time.deltaTime * dodgeSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("backwards");
            transform.Translate(Vector3.down * Time.deltaTime * dodgeSpeed);
        }

    }
}
