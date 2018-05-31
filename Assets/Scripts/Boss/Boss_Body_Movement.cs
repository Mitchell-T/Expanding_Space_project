using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Body_Movement : MonoBehaviour {

    private int Order;
    private Transform head;

    void Start()
    {
        head = GameObject.FindGameObjectWithTag("Tag_Boss").gameObject.transform;
        for (int i = 0; i < head.GetComponent<Boss_Movement>().bodyParts.Count; i++)
        {
            if (gameObject == head.GetComponent<Boss_Movement>().bodyParts[i].gameObject)
            {
                Order = i;
            }
        }
    }

    private Vector3 movementVelocity;
    [Range(0.0f, 1.0f)]
    public float overTime = 0.5f;
    void FixedUpdate()
    {
        if (Order == 0)
        {
            transform.position = Vector3.SmoothDamp(transform.position, head.position, ref movementVelocity, overTime);
            transform.LookAt(head.transform.position);
        }
        else
        {
            transform.position = Vector3.SmoothDamp(transform.position, head.GetComponent<Boss_Movement>().bodyParts[Order - 1].position, ref movementVelocity, overTime);
            transform.LookAt(head.transform.position);
        }
    }
}
