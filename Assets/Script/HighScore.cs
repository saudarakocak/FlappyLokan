using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public int highScore;
    public static int highScoreTemp;
    public GameObject NewHighScore;

    public TMP_Text text;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        loadData();

        text.text = "Highscore : " + highScore;

        if (highScoreTemp > highScore)
        {
            highScore = highScoreTemp;
            NewHighScore.gameObject.SetActive(true);
            saveManagement.SaveData(this);
        }
    }

    void loadData()
    {
        if (saveManagement.LoadData() != null)
        {
            highScore = saveManagement.LoadData().high_score;
        }else
        {
            highScore = 0;
        }
    }
    
}
