using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public void StartScene()
    {
        SceneManager.LoadScene("RoundChoiceScene");
    }

    public void RoundScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
