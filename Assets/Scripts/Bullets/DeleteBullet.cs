using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour {

    [SerializeField]
    private bool can_timeBeforeDelete;

    [SerializeField]
    private float timeBeforeDelete;

    [SerializeField]
    private Rigidbody Explosion;


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("ENEMY"))
        {
              Destroy(this.gameObject);
        }
        if (col.gameObject.CompareTag("Bullet_Boundry"))
        {
            Rigidbody clone;
            clone = Instantiate(Explosion, transform.position, transform.rotation) as Rigidbody;

            Destroy(this.gameObject);
        }
    }

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
