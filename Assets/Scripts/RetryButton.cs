using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void Stagelist()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
    }
}
