using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Point : MonoBehaviour
{

    public int point = 0 ;
    public TMP_Text pointText;
    public bool gamestop = false;

    [Header("gamepointer")]
    public GameObject enemyspawn;

    private void Update()
    {

        HighScore.highScoreTemp = point;

        pointText.text = "Score : " + point;

        if (point >= 15)
        {
            enemyspawn.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!gamestop)
        {
            if (collision.gameObject.tag == "Point")
            {
                point++;
            }
        }

        if (collision.gameObject.tag == "End")
        {
            gamestop = true;
        }else if(collision.gameObject.tag == "water")
        {
            gamestop = true;
        }else if (collision.gameObject.tag == "Enemy")
        {
            gamestop = true;
        }
    }


}
