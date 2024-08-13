using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text startText;
    public Text restart;
    public GameObject GameOver;
    public GameObject start;
    public GameObject dimBg;
    private bool isGameFrozen = true;
    public GameObject pauseBg;
    public GameObject pauseIcon;
    void Start()
    {
        Time.timeScale = 0f;
        start.GetComponent<SpriteRenderer>().enabled = true;
        restart.enabled = false;
        GameOver.GetComponent<SpriteRenderer>().enabled = false;
        GameOver.gameObject.SetActive(false);
        dimBg.GetComponent<SpriteRenderer>().enabled = false;
        pauseBg.GetComponent<SpriteRenderer>().enabled = false;
        pauseIcon.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {
        if (isGameFrozen && Input.GetKeyDown(KeyCode.Space))
        {
            UnfreezeGame();
        }
    }

    public void UnfreezeGame()
    {
        Time.timeScale = 1f; 
        start.gameObject.SetActive(false);
        isGameFrozen = false;
        startText.enabled = false;
    }
}