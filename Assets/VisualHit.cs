using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualHit : MonoBehaviour {

    public GameObject Object;

    private SpriteRenderer spriteR;

    private bool Enable = false;

    // Use this for initialization
    void Start () {
        spriteR = Object.GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Enable==true)
        {
            spriteR.color = Color.white;
        }
        else
        {
            spriteR.color = Color.white;
        }
    }
}
