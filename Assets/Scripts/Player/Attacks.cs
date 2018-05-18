using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour {

    [SerializeField]
    private float bulletSpeed = 10f;
    [SerializeField]
    private Rigidbody bullet;

    

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            Fire();
        }

	}


    // fire the bullet
    void Fire()
    {
        Vector3 bulletpos = (transform.position + new Vector3(0, -0.35f, 0.2f));

        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, transform.rotation);
        bulletClone.velocity = transform.right * bulletSpeed;
        Physics.IgnoreCollision(bulletClone.GetComponent<Collider>(), GetComponent<Collider>(), true);
        //GetComponent<AudioSource>().Play();
    }
}
