using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {

    [SerializeField]
    private float speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.fixedDeltaTime * speed);
    }
}
