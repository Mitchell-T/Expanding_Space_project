using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{

    [SerializeField]
    private GameObject[] Levels;

    [SerializeField]
    private GameObject[] Star_Cores;

    private int CurrentLevel = 0;

    private bool Switch_Level = false;

    private float CurrentLevel_Float;

    public float speed = 1f;

    public Text StarNameText;

    public Image[] Enemy_Type;

    //public Transform testpos;
    //Vector3 pos;
    private void Awake()
    {
        Enemy_Type[0].GetComponent<Image>().enabled = false;
        Enemy_Type[1].GetComponent<Image>().enabled = false;
        Enemy_Type[2].GetComponent<Image>().enabled = false;

        for (int i = 0; i < Star_Cores.Length; i++)
        {
            Star_Cores[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        Vector3 pos = transform.position;

        
        switch (CurrentLevel)
        {
            case 0:
                pos = Vector3.MoveTowards(pos, Levels[0].transform.position, speed);
                transform.position = pos;
                UpdateUI("Mesarthim");
                Enemy_Type[0].GetComponent<Image>().enabled = true;
                Enemy_Type[1].GetComponent<Image>().enabled = true;
                Enemy_Type[2].GetComponent<Image>().enabled = true;

                Star();//On and off

                break;
            case 1:
                pos = Vector3.MoveTowards(pos, Levels[1].transform.position, speed);
                transform.position = pos;
                UpdateUI("Botein");
                Enemy_Type[0].GetComponent<Image>().enabled = true;
                Enemy_Type[1].GetComponent<Image>().enabled = true;
                Enemy_Type[2].GetComponent<Image>().enabled = false;

                Star();//On and off

                break;
            case 2:
                pos = Vector3.MoveTowards(pos, Levels[2].transform.position, speed);
                transform.position = pos;
                UpdateUI("Sharatan");
                Enemy_Type[0].GetComponent<Image>().enabled = false;
                Enemy_Type[1].GetComponent<Image>().enabled = true;
                Enemy_Type[2].GetComponent<Image>().enabled = true;

                Star();//On and off

                break;
            case 3:
                pos = Vector3.MoveTowards(pos, Levels[3].transform.position, speed);
                transform.position = pos;
                UpdateUI("Hamal");
                Enemy_Type[0].GetComponent<Image>().enabled = true;
                Enemy_Type[1].GetComponent<Image>().enabled = true;
                Enemy_Type[2].GetComponent<Image>().enabled = false;

                Star();//On and off

                break;
        }

        //Switch with the keys
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Pressed: A");
            CurrentLevel++;
            Debug.Log("Current level is now: " + CurrentLevel);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Pressed: D");
            CurrentLevel--;
            Debug.Log("Current level is now: " + CurrentLevel);
        }

        if (CurrentLevel > (Levels.Length)-1)
        {
            CurrentLevel = 0;
        }

        if (CurrentLevel < 0)
        {
            CurrentLevel = Levels.Length-1;
        }

    }


    private void UpdateUI(string Name)
    {
        StarNameText.text = Name;
    }

    private void Star()
    {
        Star_Cores[CurrentLevel].SetActive(true);
        for (int i = 0; i < Star_Cores.Length; i++)
        {
            if (i != CurrentLevel)
            {
                Star_Cores[i].SetActive(false);
            }
        }
    }
}
/*
if (Switch_Level == true)
        {
            switch (CurrentLevel)
            {
                case 0:
                    GameObject.Find("SwitchSceneObject").GetComponent<SwitchScenes>().LoadLevel("Level_Mesarthim");
                break;
            }
        }
        case 0:
                //CurrentLevel_Float = float Levels[0];
                this.gameObject.transform.Translate(0, 0, 0);
                Debug.Log("Translating to position: ");
                break;
     
     
     
     */
