using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StopButton : MonoBehaviour
{
    bool isStop = false;
    public Image stopImage;

    public void stopTem()
    {
        if (Time.timeScale == 0.0f )
        {
            Time.timeScale = 1.0f;
        }
        else
        {
            Time.timeScale = 0.0f;
        }
        isStop = !isStop;
        stopImage.gameObject.SetActive(isStop);
    }
}
