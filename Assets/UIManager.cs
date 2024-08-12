using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UImanager : MonoBehaviour
{
    public Text scoreUI;
    private static int _score;
    public GameObject GameOver;
    public GameObject dimBg;
    //public HighScoreManager HighScore;
    public Text HighScoreUI;
    public Text restart;
    private int highScore;
    public GameManager gameManager;
    private bool restartCheck = false;

    private void Start()
    {
        LoadHighScore();
        scoreUI.text = $"Score: {_score}";
        HighScoreUI.text = $"High Score: {highScore}";
    }

    void Update()
    {
        
        if (restartCheck && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("yo");
            gameManager.UnfreezeGame();
        }
        
    }

    public void UpdateScore(int amount)
    {
        Debug.Log("Updating Score");
        _score += amount;
        scoreUI.text = $"Score: {_score}";
        if (_score > highScore)
        {
        HighScoreUI.text = $"High Score: {highScore}";
        }
    }
    


    public void gameOver()
    {
        SaveHighScore();
        Time.timeScale = 0f;
        GameOver.gameObject.SetActive(true);
        GameOver.GetComponent<SpriteRenderer>().enabled = true;
        dimBg.GetComponent<SpriteRenderer>().enabled = true;
        restart.enabled = true;
        restartCheck = true;
        _score = 0;
    }
    
    
    private void SaveHighScore()
    {
        if (_score > highScore)
        {
            highScore = _score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }
    public int GetHighScore()
    {
        return highScore;
    }
    public void LoadHighScore()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 0;
        }

    }
}
