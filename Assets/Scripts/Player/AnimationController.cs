using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
        //Default Fireing
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.ResetTrigger("isFiring");
            animator.SetTrigger("isFiring");

        }

        //Lazer
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.ResetTrigger("isFiringLaser");
            animator.SetTrigger("isFiringLaser");
        
        }

    }

    private void OnCollisionEnter(Collision col)
    {
        animator.SetTrigger("gotHit");
    }
}
