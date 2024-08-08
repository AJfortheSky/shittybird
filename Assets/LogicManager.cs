using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UIManager.UI;

namespace Logic
{
    public class LogicManager : MonoBehaviour
    {
        private int playerScore = 0;


        private void Start()
        {
        }

        public static void addScore()
        {
            updateScore(1);
            Debug.Log("Sir they hit the second tower");
        }
    }
}