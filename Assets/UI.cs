using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class UI : MonoBehaviour
{
    public Text scoreUI;
    private int score = 0;
    
    void Start()
    {
        scoreUI.text = $"Score: {score}";
    }
    
    
    public void updateScore()
    {
        score += 1;
    }

    public void gameOver()
    {
        
    }

    public void startScreen()
    {
        
    }
}

