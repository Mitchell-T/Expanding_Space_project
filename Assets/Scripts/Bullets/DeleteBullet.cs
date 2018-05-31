using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour {

    [SerializeField]
    private bool can_timeBeforeDelete;

    [SerializeField]
    private float timeBeforeDelete;

	// Use this for initialization
	void Start () {

        if (can_timeBeforeDelete)
        {
            Destroy(this.gameObject, timeBeforeDelete);
        }
        else
        {

            Destroy(this.gameObject);
        }
	}
	
}
