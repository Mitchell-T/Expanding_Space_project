using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Attacks : MonoBehaviour
{

    //Normal Bullet
    [SerializeField]
    private float bulletSpeed = 10f;
    [SerializeField]
    private Rigidbody bullet;
    [SerializeField]
    private bool c_shoot_bullet = true;

    //Lazer
    [SerializeField]
    GameObject lazerObj;
    [SerializeField]
    private float lazerWidthSpeed = 10f;
    [SerializeField]
    private float lazerHeightSpeed = 10f;
    [SerializeField]
    private bool c_shoot_lazer = true;

    bool c_animate = false;
    int animate_stage = 0;

    Ray lazerRay;
    RaycastHit lazerHit;

    Animator animator;
    Animator animatorFX;

    void Start()
    {
        animator = GetComponent<Animator>();
        animatorFX = GameObject.FindGameObjectWithTag("Tag_LazerFX").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (c_shoot_bullet)
            {
                Fire();
                animator.ResetTrigger("isFiring");
                animator.SetTrigger("isFiring");
                
                FindObjectOfType<AudioManager>().Play("shot_02", false);
            }
        }

        //Lazer
        if (Input.GetKeyDown(KeyCode.LeftShift))//Set the Lazer to active
        {
            //if (animate_stage==2)
            //{
            //    lazerObj.SetActive(true);
            //}
            c_shoot_bullet = false;
            c_animate = true;
            //Sound
            FindObjectOfType<AudioManager>().Play("lazer_loop_01",true);
            FindObjectOfType<AudioManager>().Play("lazer_loop_02", true);
            FindObjectOfType<AudioManager>().Play("lazer_powerup_01", false);
            FindObjectOfType<AudioManager>().Play("lazer_powerup_02", false);
            

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))//Set the Lazer to non-active
        {
            c_animate = false;
            lazerObj.SetActive(false);
            //Sound
            FindObjectOfType<AudioManager>().Falloff_Stop("lazer_loop_01",0.025f);
            FindObjectOfType<AudioManager>().Falloff_Stop("lazer_loop_02", 0.012f);
            FindObjectOfType<AudioManager>().Play("lazer_powerdown_01", false);
        }

        if (c_animate)//If can animate, do it
        {
            if (animate_stage<2)//Stage play the animation
            {
                animatorFX.SetBool("LazerFX_Start", true);
                animate_stage++;
                animator.SetInteger("FiringLazerStage", animate_stage);
            }
            if (animate_stage == 2)//Set the Lazer active when the stage reaches 2
            {
                lazerObj.SetActive(true);
                
                CameraShaker.Instance.ShakeOnce(.7f, 4f, .3f, 1f);//Shake the camera

                //if (lazerObj.GetComponent<Transform>().localScale.x <= (Screen.width))//Increase the width of the lazer when fired
                //{
                //    lazerObj.GetComponent<Transform>().localScale += new Vector3(lazerWidthSpeed, 0, 0);
                //}

                //if (lazerObj.GetComponent<Transform>().localScale.y <= 1)//-lazerObj.GetComponent<Transform>().localPosition.x))
                //{
                //    lazerObj.GetComponent<Transform>().localScale += new Vector3(0, (1 / lazerHeightSpeed), 0);
                //}
            }
        }
        else
        {
            if (animate_stage<3)//Reset everything of the animate stage
            {
                animate_stage++;
                animator.SetInteger("FiringLazerStage", animate_stage);

                //Reset the lazer width
                float wid = lazerObj.GetComponent<Lazer>().start_width;
                lazerObj.GetComponent<LineRenderer>().startWidth = wid;
                lazerObj.GetComponent<LineRenderer>().endWidth = wid;

                //if (lazerObj.GetComponent<Transform>().localScale.x >= 0)//-lazerObj.GetComponent<Transform>().localPosition.x))
                //{
                //    lazerObj.GetComponent<Transform>().localScale -= new Vector3((10f), 0, 0);

                //    if (lazerObj.GetComponent<Transform>().localScale.x <= 0.1)
                //    {
                //        lazerObj.GetComponent<Transform>().localScale = new Vector3(0, 1f, 0);
                //    }

                //}
                ////Y Scale
                //if (lazerObj.GetComponent<Transform>().localScale.y != 0)
                //{
                //    lazerObj.GetComponent<Transform>().localScale -= new Vector3(0, (0.1f) * Time.deltaTime, 0);
                //}
                //if (lazerObj.GetComponent<Transform>().localScale.x == 0)//-lazerObj.GetComponent<Transform>().localPosition.x))
                //{
                //RaycastHit2D NewRaycast = Vector2()

                c_shoot_bullet = true;//Make it so that you can shoot again
                //lazerObj.GetComponent<Transform>().localScale = new Vector3(0, 1f, 0);//Reset the transform
                animate_stage = 0;//Reset the animate stage
                animator.SetInteger("FiringLazerStage", animate_stage);//Also reset the animation
                animatorFX.SetBool("LazerFX_Start", false);//Quit the FX for the lazer
                //}
            }
        }
    }




    // fire the bullet
    void Fire()
    {
        CameraShaker.Instance.ShakeOnce(1f, 2f, .1f, 1f);

        Vector3 bulletpos = (transform.position + new Vector3(0, -0.35f, 0.2f));

        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, bulletpos, transform.rotation);

        bulletClone.velocity = transform.right * bulletSpeed;

        Physics.IgnoreCollision(bulletClone.GetComponent<Collider>(), GetComponent<Collider>(), true);
        //GetComponent<AudioSource>().Play();
    }

    // fire the lazer
    /*
    void FireLazer()
    {
        Vector3 lazerpos = (transform.position + new Vector3(0, -0.35f, 0.2f));

        Rigidbody lazerClone = (Rigidbody)Instantiate(lazer, lazerpos, transform.rotation);

        //lazerClone.velocity = transform.right * lazerSpeed;

        Physics.IgnoreCollision(lazerClone.GetComponent<Collider>(), GetComponent<Collider>(), true);
        Debug.Log("Ceated a lazer");
        //lazerClone.
        //lazerClone.velocity = transform.right * lazerSpeed;
        //Physics.IgnoreCollision(lazerClone.GetComponent<Collider>(), GetComponent<Collider>(), true);
        //GetComponent<AudioSource>().Play();
    }
    */
}
