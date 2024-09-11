using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    //public GameManager gameManager;
    public Image timeGaugeBar;
    //public float gameTime;

    // Start is called before the first frame update
    void Start()
    {
        //SetGauge(0, 30, gameManager.time);
    }

    // Update is called once per frame
    void Update()
    {
        //gameTime = gameManager.time;
        //Debug.Log(timeGaugeBar.fillAmount);
    }
    public void SetGauge(float min, float max, float time)
    {
        timeGaugeBar.fillAmount = time/max;
        if (0.67f< timeGaugeBar.fillAmount && timeGaugeBar.fillAmount <= 1f)
        {
            Debug.Log("3");
            timeGaugeBar.sprite = Resources.Load<Sprite>("curved_slider_fill_02");
        }else if(0.34f < timeGaugeBar.fillAmount && timeGaugeBar.fillAmount <= 0.67f)
        {
            Debug.Log("2");
            timeGaugeBar.sprite = Resources.Load<Sprite>("curved_slider_fill_03");
        }
        else if(timeGaugeBar.fillAmount <= 0.34f)
        {
            Debug.Log("1");
            timeGaugeBar.sprite = Resources.Load<Sprite>("curved_slider_fill_01");
        }
    }
}
