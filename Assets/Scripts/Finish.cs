using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public Text finishTxt;
    public Text finishBtn;
    public GameManager time;
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
}
