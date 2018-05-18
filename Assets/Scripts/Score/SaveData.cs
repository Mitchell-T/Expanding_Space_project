[System.Serializable]
public class SaveData
{
    public float highScore;
    public string playerName;

    public SaveData(float score, string name)
    {
        highScore = score;
        playerName = name;
    }

}