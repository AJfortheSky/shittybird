using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class UI : MonoBehaviour
{
    public Text scoreUI;
    private static int _score;


    private void Start()
    {
        scoreUI.text = $"Score: {_score}";
    }


    public void UpdateScore(int amount)
    {
        Debug.Log("Updating Score");
        _score += amount;
        scoreUI.text = $"Score: {_score}";
    }


    public void gameOver()
    {
        Time.timeScale = 0f;
        //HighScoreManager.SaveHighScore();
        //gameOverText.gameObject.SetActive(true);
    }
    
}
