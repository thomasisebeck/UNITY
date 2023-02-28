using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;

    [ContextMenu("Add score tester")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

}
