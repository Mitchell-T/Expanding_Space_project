using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour {

    [SerializeField]
    private float timeBeforeDelete;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, timeBeforeDelete);
	}
	
}
