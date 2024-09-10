using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public GameManager gameManager;
    public void StrageListOrRetry()
    {
        if (gameManager.cardCount == 0)
        {
            SceneManager.LoadScene("RoundChoiceScene");
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
