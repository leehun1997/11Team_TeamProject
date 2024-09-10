using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public Text finishTxt;
    public Text finishBtn;

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
        finishBtn.text = "StageList";
    }
    public void gameFail()
    {
        finishTxt.text = "Fail";
        finishBtn.text = "Retry?";
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
                stagemanger.GetComponent<StageManger>().clearStage1 = true;
            }
            else if (diff == 2)
            {
                MemberNameTxt.text = "서영석";
                memberImage1.sprite = Resources.Load<Sprite>($"seo1");
                memberImage2.sprite = Resources.Load<Sprite>($"seo2");
                lovePePero1.sprite = Resources.Load<Sprite>($"Pepero3");
                lovePePero2.sprite = Resources.Load<Sprite>($"Pepero7");
                stagemanger.GetComponent<StageManger>().clearStage2 = true;
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
                stagemanger.GetComponent<StageManger>().clearStage3 = true;
            }
            else if (diff == 2)
            {
                MemberNameTxt.text = "이훈";
                memberImage1.sprite = Resources.Load<Sprite>($"LeeHun1");
                memberImage2.sprite = Resources.Load<Sprite>($"LeeHun2");
                lovePePero1.sprite = Resources.Load<Sprite>($"Pepero0");
                lovePePero2.sprite = Resources.Load<Sprite>($"Pepero1");
                stagemanger.GetComponent<StageManger>().clearStage4 = true;
            }
        }
    }
}
