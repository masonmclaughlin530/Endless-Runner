using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float score;
    public TMP_Text guiScore;
    private GameObject gameManager;
    private Timer timer;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //setScore();
        time += Time.deltaTime;
    }

    public float getScore()
    {
        return score;
    }

    public void addToScore( float val)
    {
        score += val;
        setScore();
    }

    public void setScore()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            //score += Time.deltaTime;
            //guiScore.text = "Score: ";
            //guiScore.text += ((int)score).ToString();

        }

        guiScore.text = "Score: ";
        guiScore.text += ((int)score).ToString();


    }

    public int finalScore()
    {
        
        score += time;
        Debug.Log("timer test" +  score);
        

        int finalScore = (int)score;

        return finalScore;
    }


}
