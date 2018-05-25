using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Projectile_Hit : MonoBehaviour {

    //public CamaraShake camaraShake;

    private void OnTriggerEnter(Collider other)
    {
        print("hit cube");
        if (other.gameObject.tag == "Cube")
        {
            //Kill those S.O.B.s
            //StartCoroutine(camaraShake.Shake(.15f,.4f));
            UpdateScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        print("hit wall");
        if (other.gameObject.tag == "Tag_Wall")
        {
        //    GameObject wall = other.con;
        //    Rigidbody.AddForce(Vector3.Reflect(30f, wall), ForceMode.Impulse);
        }

        print("hit boundry");
        if (other.gameObject.tag == "Tag_Wall_Projectile_Boundry")
        {
            //Kill the bullet
            Destroy(gameObject);
        }
    }

    private void OnColliderEnter(Collision other)
    {
        print("hit cube");
        if (other.gameObject.tag == "Cube")
        {
            //Kill those S.O.B.s
            //StartCoroutine(camaraShake.Shake(.15f,.4f));
            UpdateScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        print("hit wall");
        if (other.gameObject.tag == "Tag_Wall")
        {
        //    GameObject wall = other.con;
        //    Rigidbody.AddForce(Vector3.Reflect(30f, wall), ForceMode.Impulse);
        }

        print("hit boundry");
        if (other.gameObject.tag == "Tag_Wall_Projectile_Boundry")
        {
            //Kill the bullet
            Destroy(gameObject);
        }
    }
    private void UpdateScore()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("ScoreKeeper");
        obj.GetComponent<scr_Score>().AddScore(100);
     //   gameObject.Score_Keeper.Score_Board += 100;
    }
}
