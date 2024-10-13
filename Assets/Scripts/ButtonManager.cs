using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    private GameManager gameManager;
    public TMP_Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        highscore();
    }

   public void resumerGame()
    {
        gameManager.resumeGame();
    }

    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level01");
        
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void options()
    {
        SceneManager.LoadScene("Options");
    }

    public void highscore()
    {
        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
    }

}
