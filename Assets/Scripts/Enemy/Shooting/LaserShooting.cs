using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooting : MonoBehaviour {

    public bool fire;

    [SerializeField]
    private float xToFire;

    [SerializeField]
    private Rigidbody bullet;

        private Rigidbody bulletClone;


    //// Update is called once per frame
    //void Update()
    //{
    //    if (fire && transform.position.x <= xToFire)
    //    {

    //        StartCoroutine(FireOnce());
    //        fire = false;
    //    }

    //}

    //IEnumerator FireOnce()
    //{         
    //            Vector3 bulletpos = (transform.position + new Vector3(0, 0, 0.2f));

    //            Quaternion rotation = Quaternion.Euler(0, 0, 90);

    //            bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, rotation);

    //            yield return new WaitForSeconds(0.4f);
         
    //}
}

