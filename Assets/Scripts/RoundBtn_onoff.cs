using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundBtn_onoff : MonoBehaviour
{
    public Button Btn1;
    public Button Btn2;
    public Button Btn3;
    public Button Btn4;
    //public Button Btn5;
    Image image;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("StageClear", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("StageClear") == 1)
        {
            Btn2.GetComponent<Button>().interactable = true;
            //image = Btn2.GetComponent<Image>();
            //Color tem = image.color;
            //tem.a = 1.0f;
            //image.color = tem;
        }
        else if (PlayerPrefs.GetInt("StageClear") == 2)
        {
            Btn3.GetComponent<Button>().interactable = true;
        }
        else if (PlayerPrefs.GetInt("StageClear") == 3)
        {
            Btn4.GetComponent<Button>().interactable = false;
        }
        //else if (PlayerPrefs.GetInt("StageClear") == 4)
        //{
            //Btn5.gameObject.SetActive(true);
        //}
    }
}
