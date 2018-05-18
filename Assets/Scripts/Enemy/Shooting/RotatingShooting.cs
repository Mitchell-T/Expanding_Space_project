﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingShooting : MonoBehaviour {

    public bool fire;

    [SerializeField]
    private bool reverse;

    [SerializeField]
    private bool both;

    [SerializeField]
    private Rigidbody bullet;

    private Rigidbody bulletClone;


    // Update is called once per frame
    void Update () {
		if (fire)
        {
            StartCoroutine(FireOnce());
            fire = false;
        }

	}

    IEnumerator FireOnce()
    {
        if (!reverse && !both)
        {

            float rotationAngle = 60;

            for (int i = 0; i < 7; i++)
            {

                Vector3 bulletpos = (transform.position + new Vector3(0, 0, 0.2f));

                Quaternion rotation = Quaternion.Euler(0, 0, rotationAngle);

                rotationAngle += 10;

                bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, rotation);

                yield return new WaitForSeconds(0.4f);
            }
        }

        if (reverse && !both)
        {

            float rotationAngleB = 120;

            for (int i = 0; i < 7; i++)
            {

                Vector3 bulletpos = (transform.position + new Vector3(0, 0, 0.2f));

                Quaternion rotation = Quaternion.Euler(0, 0, rotationAngleB);

                rotationAngleB -= 10;

                bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, rotation);

                yield return new WaitForSeconds(0.4f);
            }
        }

        if (both)
        {

            float rotationAngle = 60;

            float rotationAngleB = 120;

            for (int i = 0; i < 7; i++)
            {

                //get bulletpos for bullets
                Vector3 bulletpos = (transform.position + new Vector3(0, 0, 0.2f));
                //get rotation
                Quaternion rotation = Quaternion.Euler(0, 0, rotationAngle);
                //fire
                bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, rotation);

                //get second rotation
                rotation = Quaternion.Euler(0, 0, rotationAngleB);
                //fire
                bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, rotation);

                //change rotations for next bullet
                rotationAngle += 10;
                rotationAngleB -= 10;

                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}