using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    static public int score = 0;
    static public int highscore;
    public Text HighScoreText;
    public Text Score;
    public GameObject home;
    // Start is called before the first frame update
    void Start()
    {
        UpdateHighScore();
        home.SetActive(false);
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("lv2");
        }
        if (other.tag == "new")
        {
            SceneManager.LoadScene("Level1");
        }
        if (other.tag == "end")
        {
            Time.timeScale = 0.5f;
            home.SetActive(true);

        }
    }
}
