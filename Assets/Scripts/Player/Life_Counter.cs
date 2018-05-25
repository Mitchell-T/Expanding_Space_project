using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_Counter : MonoBehaviour
{

    public Text uiText;
    public Text ScoreText;
    public int Lives = 3;
    public int Score = 0;

    private void Start()
    {
        UpdateUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("hit");
        if (other.gameObject.tag=="Cube")
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        Lives--;

        UpdateUI();

        if (Lives<=0)
        {
            GameObject screen_main = GameObject.FindGameObjectWithTag("Tag_Screen_Main");
            screen_main.GetComponent<Canvas>().enabled = false;

            GameObject screen_death = GameObject.FindGameObjectWithTag("Tag_Screen_Death");
            screen_death.GetComponent<Canvas>().enabled = true;

            GameObject score_board = GameObject.FindGameObjectWithTag("ScoreKeeper");
            ScoreText.text = "Score: " + score_board.GetComponent<scr_Score>().Score_Board;
        }
    }

    private void UpdateUI()
    {
        uiText.text = "Lives: " + Lives.ToString();
    }
}
