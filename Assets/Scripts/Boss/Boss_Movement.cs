using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Boss_Movement : MonoBehaviour
{
    public List<Transform> bodyParts = new List<Transform>();

    public float MoveSpeed = 5.0f;

    public float frequency = 20.0f;  // Speed of sine movement
    public float magnitude = 0.5f;   // Size of sine movement
    private Vector3 axis;
    public bool reverseWave;

    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        axis = transform.up;  // May or may not be the axis you want
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
        //    currentRotation += rotationSensitivity * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    currentRotation -= rotationSensitivity * Time.deltaTime;
        //}

        if (!reverseWave)
        {
            //pos += -transform.right * Time.deltaTime * MoveSpeed;
            transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
        }
        else if (reverseWave)
        {
            //pos += -transform.right * Time.deltaTime * MoveSpeed;
            transform.position = pos + axis * Mathf.Sin(Time.time * -frequency) * magnitude;
        }
    }

    //public float speed = 3.5f;

    //public float currentRotation;
    //public float rotationSensitivity = 50.0f;

    //void FixedUpdate()
    //{
    //    MoveForward();
    //    Rotation();
    //}

    //void MoveForward()
    //{
    //    transform.position += transform.up * speed * Time.deltaTime;

    //}

    //void Rotation()
    //{
    //    transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, currentRotation));
    //}
}




/*
using UnityEngine;
using System.Collections;

public class Boss_Movement : MonoBehaviour
{

    public float MoveSpeed = 5.0f;

    public float frequency = 20.0f;  // Speed of sine movement
    public float magnitude = 0.5f;   // Size of sine movement
    private Vector3 axis;
    public bool reverseWave;

    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        axis = transform.up;  // May or may not be the axis you want

    }

    void Update()
    {
        if (!reverseWave)
        {
            pos += -transform.right * Time.deltaTime * MoveSpeed;
            transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
        } else if (reverseWave)
        {
            pos += -transform.right * Time.deltaTime * MoveSpeed;
            transform.position = pos + axis * Mathf.Sin(Time.time * -frequency) * magnitude;
        }

        
    }
}
*/
