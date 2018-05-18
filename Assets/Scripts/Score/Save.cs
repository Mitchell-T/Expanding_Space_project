using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class save : MonoBehaviour
{
    float currentScore = 0;
    string currentName = "";

    void Start()
    {
        
    }

    public void SaveFile()
    {
        string dest = Application.persistentDataPath + "/savedata.dat";
        FileStream fStream;

        if (File.Exists(dest))
        {
            fStream = File.OpenWrite(dest);
        } else
        {
            fStream = File.Create(dest);
        }

        SaveData data = new SaveData(currentScore, currentName);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fStream, data);
        fStream.Close();

    }

    public void LoadFile()
    {
        string dest = Application.persistentDataPath + "/savedata.dat";
        FileStream fstream;

        if (File.Exists(dest)) fstream = File.OpenRead(dest);
        else
        {
            Debug.LogError("File not found! : " + dest);
            return;
        }

        BinaryFormatter bf = new BinaryFormatter();
        SaveData data = (SaveData)bf.Deserialize(fstream);
        fstream.Close();

        currentScore = data.highScore;
        currentName = data.playerName;

        Debug.Log(data.playerName);
        Debug.Log(data.highScore);
    }



}