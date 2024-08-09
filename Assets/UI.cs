
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



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

    public void GameOver()
    {
    }
}
