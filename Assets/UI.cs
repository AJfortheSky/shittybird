using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

namespace UIManager
{
    public class UI : MonoBehaviour
    {
        public Text scoreUI;
        private static int score = 0;


        private void Start()
        {
            scoreUI.text = $"Score: {score}";
        }


        public static void updateScore(int amount)
        {
            score += amount;
        }

        public void gameOver()
        {
        }
    }
}