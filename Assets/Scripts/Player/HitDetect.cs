using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using EZCameraShake;

public class HitDetect : MonoBehaviour
{
    [SerializeField]
    public Text LivesText;
    [SerializeField]
    public Text ScoreText;
    public static int Lives = 3;
    public static int Score = 0;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ENEMY" || other.gameObject.tag == "ENEMYBULLET")
        {
            Destroy(other.gameObject);
            //if (other.gameObject.tag == "ENEMY")
            //{
            //    StartCoroutine(other.gameObject.GetComponent <scr_HitDetection>()._Destroy(1f));
            //}
            
            TakeDamage();
        }
        if (other.gameObject.tag == "Planet_Core")
        {
            Destroy(other.gameObject);
            Score += 10000;
        }
    }

    private void TakeDamage()
    {
        Lives--;

        //Camera Shake
        CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);

        var colors = new Color[2];


        if (Lives <= 0)
        {
            //GameObject screen_main = GameObject.FindGameObjectWithTag("Tag_Screen_Main");
            //screen_main.GetComponent<Canvas>().enabled = false;

            //GameObject screen_death = GameObject.FindGameObjectWithTag("Tag_Screen_Death");
            //screen_death.GetComponent<Canvas>().enabled = true;

            //GameObject score_board = GameObject.FindGameObjectWithTag("ScoreKeeper");
            //ScoreText.text = "Score: " + score_board.GetComponent<scr_Score>().Score_Board;

            SceneManager.LoadScene(2);
            //SceneManager.UnloadSceneAsync(1);
        }
    }

    void Update()
    {
        LivesText.text = "Lives: " + Lives.ToString();
        //ScoreText.text = "Score: " + Score.ToString();
    }

}
