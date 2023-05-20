using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TMP_Text text;
    public Point pointP;
    public GameObject endUI, cameraOff, DeadAnimation, DamagedPanel;
    

    private void Start()
    {
        pointP = GetComponent<Point>();
    }

    private void Update()
    {

        text.text = "Score : " + pointP.point;
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "End")
        {
            endUI.gameObject.SetActive(true);
            Time.timeScale = 1;
        }
        else if (collision.gameObject.tag == "water")
        {
            FindObjectOfType<AudioManager>().stop("Theme");
            FindObjectOfType<AudioManager>().stop("Theme1");
            FindObjectOfType<AudioManager>().stop("Theme2");
            FindObjectOfType<AudioManager>().Play("Splash");
            DeadAnimation.gameObject.SetActive(true);
            cameraOff.gameObject.SetActive(false);
            Time.timeScale = 1;

        }else if (collision.gameObject.tag == "Enemy")
        {
            DamagedPanel.gameObject.SetActive(true);
        }
    }
}
