using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    public Image timeGaugeBar;

    public void SetGauge(float min, float max, float time)
    {
        timeGaugeBar.fillAmount = time/max;
        if (0.67f< timeGaugeBar.fillAmount && timeGaugeBar.fillAmount <= 1f)
        {
            timeGaugeBar.sprite = Resources.Load<Sprite>("curved_slider_fill_02");
        }else if(0.34f < timeGaugeBar.fillAmount && timeGaugeBar.fillAmount <= 0.67f)
        {
            timeGaugeBar.sprite = Resources.Load<Sprite>("curved_slider_fill_03");
        }
        else if(timeGaugeBar.fillAmount <= 0.34f)
        {
            timeGaugeBar.sprite = Resources.Load<Sprite>("curved_slider_fill_01");
        }
    }
}
