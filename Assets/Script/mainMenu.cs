using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject transisi;

    private void Start()
    {
        transisi.gameObject.SetActive(false);
    }

    public void startGame()
    {
        Time.timeScale = 1;
        transisi.gameObject.SetActive(true);
        Invoke("PlayIt", 1);

    }
    void PlayIt()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void backToMainMenu()
    {
        Time.timeScale = 1;
        PlayGame.Play = false;
        transisi.gameObject.SetActive(true);
        Invoke("MenuGame", 0.5f);
    }
    public void restart()
    {
        Time.timeScale = 1;
        PlayGame.Play = false;
        transisi.gameObject.SetActive(true);
        Invoke("restartGame", 0.5f);
    }
    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    void MenuGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
    public void exitGame()
    {
        Application.Quit();
    }
}
