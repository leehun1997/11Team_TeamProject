using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StopButton : MonoBehaviour
{
    bool isStop = false;
    public Image stopImage;
    public Image stopBtn;

    public void stopTem()
    {
        if (Time.timeScale == 0.0f )
        {
            Time.timeScale = 1.0f;
            stopBtn.sprite = Resources.Load<Sprite>("button_04");
        }
        else
        {
            Time.timeScale = 0.0f;
            stopBtn.sprite = Resources.Load<Sprite>("button_pressed_03");
        }
        isStop = !isStop;
        stopImage.gameObject.SetActive(isStop);
    }
}
