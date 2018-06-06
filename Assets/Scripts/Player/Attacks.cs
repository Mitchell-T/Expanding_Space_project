using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour {

    [SerializeField]
    private float bulletSpeed = 10f;
    [SerializeField]
    private Rigidbody bullet;

    [SerializeField]
    private float lazerSpeed = 10f;
    [SerializeField]
    private Rigidbody lazer;



    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            FireLazer();
        }
    }


    // fire the bullet
    void Fire()
    {
        Vector3 bulletpos = (transform.position + new Vector3(0, -0.35f, 0.2f));

        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, transform.rotation);
        bulletClone.velocity = transform.right * bulletSpeed;
        Physics.IgnoreCollision(bulletClone.GetComponent<Collider>(), GetComponent<Collider>(), true);
        FindObjectOfType<AudioManager>().Play("c1");
    }

    // fire the lazer
    void FireLazer()
    {
        Vector3 lazerpos = (transform.position + new Vector3(0, 0, 0));

        Rigidbody lazerClone = (Rigidbody)Instantiate(lazer, lazerpos, transform.rotation);
        //lazerClone.velocity = transform.right * lazerSpeed;
        Physics.IgnoreCollision(lazerClone.GetComponent<Collider>(), GetComponent<Collider>(), true);
        FindObjectOfType<AudioManager>().Play("c2");
    }
}
