using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Core_Mouth : MonoBehaviour {


    public Rigidbody Star_core;
    Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <= Star_core.position.x - 20)
        {
            animator.SetInteger("FiringLazerStage", 0);
        }
        
        
	}
}
