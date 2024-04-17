using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore = 0;
    private int aiScore = 0;

    public UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void PlayerScored()
    {
        playerScore++;
        uiManager.ShowGameOver("Player scored! Press Play Again to continue.");
        CheckEndCondition();
    }

    public void AIScored()
    {
        aiScore++;
        uiManager.ShowGameOver("AI scored! Press Play Again to continue.");
        CheckEndCondition();
    }

    void CheckEndCondition()
    {
        if (playerScore >= 5)
        {
            uiManager.ShowGameOver("Player wins! Press Play Again to continue.");
        }
        else if (aiScore >= 5)
        {
            uiManager.ShowGameOver("AI wins! Press Play Again to continue.");
        }
    }

    public void ResetGame()
    {
        playerScore = 0;
        aiScore = 0;
        uiManager.StartGame();
    }
}
