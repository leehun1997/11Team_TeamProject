using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundBtnManger : MonoBehaviour
{
    GameObject stagemanger;

    public Button roundbtn1;
    public Button roundbtn2;
    public Button roundbtn3;
    public Button roundbtn4;
    public GameObject roundbtn5;

    // Start is called before the first frame update
    private void Awake()
    {
        stagemanger = GameObject.Find("StageManger");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enabled_BtnCheck();
        if (stagemanger.GetComponent<StageManger>().clearStage1 == true)
        {            
            roundbtn2.GetComponent<Button>().interactable = true;
            roundbtn2.transform.GetChild(1).GetComponent<Animator>().SetBool("clearStage1", true);
        }
        if (stagemanger.GetComponent<StageManger>().clearStage2 == true)
        {            
            roundbtn3.GetComponent<Button>().interactable = true;
            roundbtn3.transform.GetChild(1).GetComponent<Animator>().SetBool("clearStage2", true);
        }
        if (stagemanger.GetComponent<StageManger>().clearStage3 == true)
        {
            roundbtn4.GetComponent<Button>().interactable = true;
            roundbtn4.transform.GetChild(1).GetComponent<Animator>().SetBool("clearStage3", true);
        }
        if (stagemanger.GetComponent<StageManger>().clearStage4 == true)
        {
            roundbtn5.SetActive(true);
            if (PlayerPrefs.GetInt("maxStage") == 3)
            {
                roundbtn5.GetComponent<Animator>().SetBool("clearStage4", true);
            }
        }
    }
    void enabled_BtnCheck() 
    {     
        if(PlayerPrefs.GetInt("maxStage") == 3){            
            roundbtn1.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn2.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn3.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn4.transform.GetChild(1).GetComponent<Image>().enabled = false;
        }
        else if (PlayerPrefs.GetInt("maxStage") == 2)
        {
            roundbtn1.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn2.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn3.transform.GetChild(1).GetComponent<Image>().enabled = false;
        }
        else if (PlayerPrefs.GetInt("maxStage") == 1)
        {
            roundbtn1.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn2.transform.GetChild(1).GetComponent<Image>().enabled = false;
        }
        else if (PlayerPrefs.GetInt("maxStage") == 0) //처음으로 라운드1을 눌렀을 때
        {
            roundbtn1.transform.GetChild(1).GetComponent<Image>().enabled = false;
        }
    }
}
