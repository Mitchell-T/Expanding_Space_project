using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour {
    
    public float lives = 1;
    public Rigidbody Explosion;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {
            lives -= 1;
            if(lives <= 0)
            {
                Destroy(col.gameObject);
                StartCoroutine(_Destroy(1f));
            }
            else if (lives >= 1)
            {
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.CompareTag("Player"))
        {
                StartCoroutine(_Destroy(1f));
        }
    }

    public IEnumerator _Destroy(float time_sec)
    {
        int current_stage = 0;
        int end_stage = 2;//Total of 3 stages

        while (current_stage < end_stage)
        {
            //if (current_stage == 0)
            //{
            //    //Stage 0
            //    //Gib score
            //    GameObject.FindGameObjectWithTag("Tag_Scoreobject").GetComponent<scr_Score>().AddScore(100);
            //    Debug.Log("Current Stage: " + current_stage);
            //}
            //else if (current_stage == 1)
            //{
            //    Debug.Log("Current Stage: " + current_stage);
            //}
            //else if (current_stage == 2)
            //{
            //    //Stage 2
            //    //Destroy it
            //    Rigidbody clone;
            //    clone = Instantiate(Explosion, transform.position, transform.rotation) as Rigidbody;

            //    Debug.Log("DEAD");
            //    Destroy(this.gameObject);
            //    Debug.Log("Current Stage: " + current_stage);
            //}
            

            current_stage++;
            yield return null;//new WaitForSeconds(time_sec)
        }
        GameObject.FindGameObjectWithTag("Tag_Scoreobject").GetComponent<scr_Score>().AddScore(100);
        //    Debug.Log("Current Stage: " + current_stage);
        Rigidbody clone;
        clone = Instantiate(Explosion, transform.position, transform.rotation) as Rigidbody;

        FindObjectOfType<AudioManager>().Play("explosion_01", false);

        Debug.Log("DEAD");
        Destroy(this.gameObject);
        Debug.Log("Current Stage: " + current_stage);
    }



}
