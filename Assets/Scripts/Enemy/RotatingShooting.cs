using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingShooting : MonoBehaviour {

    public bool fire;

    [SerializeField]
    private bool reverse;

    [SerializeField]
    private Rigidbody bullet;


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
        if (!reverse)
        {

            float rotationAngle = 60;

            for (int i = 0; i < 7; i++)
            {

                Vector3 bulletpos = (transform.position + new Vector3(0, 0, 0.2f));

                Quaternion rotation = Quaternion.Euler(0, 0, rotationAngle);

                rotationAngle += 10;

                Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, rotation);

                yield return new WaitForSeconds(0.2f);
            }
        }

        if (reverse)
        {

            float rotationAngle = 120;

            for (int i = 0; i < 7; i++)
            {

                Vector3 bulletpos = (transform.position + new Vector3(0, 0, 0.2f));

                Quaternion rotation = Quaternion.Euler(0, 0, rotationAngle);

                rotationAngle -= 10;

                Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, rotation);

                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}
