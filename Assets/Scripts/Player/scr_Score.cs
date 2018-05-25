using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_Score : MonoBehaviour
{

    public Text uiText;
    public int Score_Board = 0;

    private void Start()
    {
        UpdateUI();
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        print("hit cube");
        if (other.gameObject.tag == "Cube")
        {
            //Kill those S.O.B.s
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    */
    public void AddScore(int score)
    {
        Score_Board += score;
        UpdateUI();
    }


    private void UpdateUI()
    {
        uiText.text = "Score: " + Score_Board.ToString();
    }

}
