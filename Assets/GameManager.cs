using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public Text startText; // Reference to the UI Text component
    private bool isGameFrozen = true;

    void Start()
    {
        // Start with the game frozen
        Time.timeScale = 0f;
        //startText.gameObject.SetActive(true); // Show the "Press Space to Start" text
    }

    void Update()
    {
        if (isGameFrozen && Input.GetKeyDown(KeyCode.Space))
        {
            UnfreezeGame();
        }
    }

    void UnfreezeGame()
    {
        Time.timeScale = 1f; // Unfreeze the game
        //startText.gameObject.SetActive(false); // Hide the start text
        isGameFrozen = false;
    }
}