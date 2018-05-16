using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour {

    public float lives = 1;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {

            lives -= 1;
            if(lives <= 0)
            {
                Destroy(col.gameObject);
                Destroy(this.gameObject);
            } else if (lives >= 1)
            {
                Destroy(col.gameObject);
            }


        }
    }
}
