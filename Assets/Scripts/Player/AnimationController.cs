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
		
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.ResetTrigger("isFiring");
            animator.SetTrigger("isFiring");

        }



        

	}

    private void OnCollisionEnter(Collision col)
    {
        animator.SetTrigger("gotHit");
    }
}
