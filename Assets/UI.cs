using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class UI : MonoBehaviour
{
    public Text scoreUI;
    public static int score = 0;
    public static GameObject gameOverScreen;
    void Start()
    {
        scoreUI.text = $"Score: {score}";
        gameOverScreen.SetActive(true);
    }
    
    
    public static void updateScore()
    {
        score += 1;
    }

    public static void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

