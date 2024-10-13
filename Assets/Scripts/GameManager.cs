using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.Search;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject pauseMenu;
    public TMP_Text finalScore;
    private Score playerScore;
    public GameObject gameOverMenu;
    private bool playGame = true;
    public TMP_Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = gameObject.GetComponent<Score>();
        //highscore();
        playGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        pauseButtonPress();

        if (GameObject.FindGameObjectWithTag("Player") == null && playGame)
        {
            gameOver();
            playGame = false;
        }
    }

    public void pauseButtonPress()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        gameOverMenu.SetActive(true);
        int score = playerScore.finalScore();

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);

        }
        finalScore.text = "Final Score: " + score;
        
        
    }

    public void highscore()
    {
        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
    }


}
