using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    int stage;
    int diff;
    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Question(int stage, int diff)
    {

    }
}
