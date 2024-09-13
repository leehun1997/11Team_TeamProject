using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public Text finishTxt;

    int stage, diff;
    GameObject stagemanger;

    public Text MemberNameTxt;
    public Image memberImage1;
    public Image memberImage2;
    public Image lovePePero1;
    public Image lovePePero2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameClear()
    {
        finishTxt.text = "Clear";
    }
    public void gameFail()
    {
        finishTxt.text = "Fail";
    }
    public void ServiceView()
    {
        stagemanger = GameObject.Find("StageManger");
        stage = stagemanger.GetComponent<StageManger>().stage;
        diff = stagemanger.GetComponent<StageManger>().diff;
        if(stage == 1)
        {
            if(diff == 1)
            {
                MemberNameTxt.text = "최인석";
                memberImage1.sprite = Resources.Load<Sprite>($"cis1");
                memberImage2.sprite = Resources.Load<Sprite>($"cis2");
                lovePePero1.sprite = Resources.Load<Sprite>($"Pepero4");
                lovePePero2.sprite = Resources.Load<Sprite>($"Pepero5");
                if (PlayerPrefs.GetInt("clearStage")<1)
                {
                    PlayerPrefs.SetInt("clearStage", 1);
                }
            }
            else if (diff == 2)
            {
                MemberNameTxt.text = "서영석";
                memberImage1.sprite = Resources.Load<Sprite>($"seo1");
                memberImage2.sprite = Resources.Load<Sprite>($"seo2");
                lovePePero1.sprite = Resources.Load<Sprite>($"Pepero3");
                lovePePero2.sprite = Resources.Load<Sprite>($"Pepero7");
                if (PlayerPrefs.GetInt("clearStage") < 2)
                {
                    PlayerPrefs.SetInt("clearStage", 2);
                }
            }
        }
        else if (stage == 2)
        {
            if (diff == 1)
            {
                MemberNameTxt.text = "성기혁";
                memberImage1.sprite = Resources.Load<Sprite>($"KiHyeok1");
                memberImage2.sprite = Resources.Load<Sprite>($"KiHyeok2");
                lovePePero1.sprite = Resources.Load<Sprite>($"Pepero2");
                lovePePero2.sprite = Resources.Load<Sprite>($"Pepero6");
                if (PlayerPrefs.GetInt("clearStage") < 3)
                {
                    PlayerPrefs.SetInt("clearStage", 3);
                }
            }
            else if (diff == 2)
            {
                MemberNameTxt.text = "이훈";
                memberImage1.sprite = Resources.Load<Sprite>($"LeeHun1");
                memberImage2.sprite = Resources.Load<Sprite>($"LeeHun2");
                lovePePero1.sprite = Resources.Load<Sprite>($"Pepero0");
                lovePePero2.sprite = Resources.Load<Sprite>($"Pepero1");
                if (PlayerPrefs.GetInt("clearStage") < 4)
                {
                    PlayerPrefs.SetInt("clearStage", 4);
                }
            }
        }else if (stage==3)
        {
            MemberNameTxt.text = "Perfect!";
            memberImage1.sprite = Resources.Load<Sprite>($"LeeHun2");
            memberImage2.sprite = Resources.Load<Sprite>($"KiHyeok1");
            lovePePero1.sprite = Resources.Load<Sprite>($"seo2");
            lovePePero2.sprite = Resources.Load<Sprite>($"cis2");
            if (PlayerPrefs.GetInt("clearStage") < 5)
            {
                PlayerPrefs.SetInt("clearStage", 5);
            }
        }
    }
}
