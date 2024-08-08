using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text startText;
    public Text gameOverText;
    private bool isGameFrozen = true;

    void Start()
    {
        Time.timeScale = 0f;
        startText.gameObject.SetActive(true); 
        gameOverText.gameObject.SetActive(false);
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
        Time.timeScale = 1f; 
        startText.gameObject.SetActive(false); 
        isGameFrozen = false;
    }
}