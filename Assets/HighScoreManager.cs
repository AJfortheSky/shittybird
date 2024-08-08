using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    private int highScore;
    // Start is called before the first frame update
    void Start()
    {
        LoadHighScore();
    }

    public void SaveHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    public int GetHighScore()
    {
        return highScore;
    }

    private void LoadHighScore()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
