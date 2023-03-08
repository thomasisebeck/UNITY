using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int playerScore;
    public GameObject bird;
    public GameObject gameOverScreen; 

    public void setScore(int newScore)
    {
        scoreText.text = newScore.ToString();
    }

    [ContextMenu("IncreaseScore")]
    public void addScore()
    {
        setScore(++playerScore);
    }

    [ContextMenu("Restart")]
    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    
}
