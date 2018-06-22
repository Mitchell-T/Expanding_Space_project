using UnityEngine;
using System.Collections;

public class SineWave_Movement : MonoBehaviour
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
            pos += -transform.right * Time.deltaTime * 5f;
            transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
        } else if (reverseWave)
        {
            pos += -transform.right * Time.deltaTime * 5f;
            transform.position = pos + axis * Mathf.Sin(Time.time * -frequency) * magnitude;
        }

        
    }
}