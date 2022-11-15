using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    static public int score = 0;
    static public int highscore;
    public Text HighScoreText;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        UpdateHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        //void Highscore() 
        //{
            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
        //}
        UpdateHighScore();
        Score.text = $"SCORE:{score}";
        HighScoreText.text = $"HighScore:{PlayerPrefs.GetInt("HighScore", 0)}";
    }
    public void UpdateHighScore() 
    {
        HighScoreText.text = $"HighScore:{PlayerPrefs.GetInt("HighScore",0)}";
    }

    static public void Gameover()
    {
        Debug.Log("over");
        Time.timeScale = 0;
        
        Debug.Log(score);
    }
    

}
