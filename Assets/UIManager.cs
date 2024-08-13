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
    private bool pauseCheck = true;
    public GameObject pauseBg;
    public GameObject pauseIcon;


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
            restartGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
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
    
    public void PauseGame()
    {
        if(pauseCheck && restartCheck == false)
        {
            Time.timeScale = 0f;
            pauseBg.GetComponent<SpriteRenderer>().enabled = true;
            pauseIcon.GetComponent<SpriteRenderer>().enabled = true;
            pauseCheck = false;
        }
        else if (restartCheck)
        {
            
        }
        else
        {
            Time.timeScale = 1f;
            pauseBg.GetComponent<SpriteRenderer>().enabled = false;
            pauseIcon.GetComponent<SpriteRenderer>().enabled = false;
            pauseCheck = true;
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
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameManager.UnfreezeGame();
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
