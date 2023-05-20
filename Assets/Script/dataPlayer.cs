using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class dataPlayer
{
    public int high_score;

    public dataPlayer(HighScore _highscore)
    {
        high_score = _highscore.highScore;
    }

}
