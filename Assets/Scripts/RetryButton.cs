using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{
    public GameObject stageManger;
    
    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void StageScene()
    {
        SceneManager.LoadScene("RoundChoiceScene");
    }

    public void RoundScene()
    {
        stageManger = GameObject.Find("StageManger");
        if(this.gameObject.name == "1RoundButton")
        {
            stageManger.GetComponent<StageManger>().stage = 1;
            stageManger.GetComponent<StageManger>().diff = 1;
        }
        else if (this.gameObject.name == "2RoundButton")
        {
            stageManger.GetComponent<StageManger>().stage = 1;
            stageManger.GetComponent<StageManger>().diff = 2;
        }
        else if (this.gameObject.name == "3RoundButton")
        {
            stageManger.GetComponent<StageManger>().stage = 2;
            stageManger.GetComponent<StageManger>().diff = 1;
        }
        else if (this.gameObject.name == "4RoundButton")
        {
            stageManger.GetComponent<StageManger>().stage = 2;
            stageManger.GetComponent<StageManger>().diff = 2;
        }
        else if (this.gameObject.name == "5RoundButton")
        {
            stageManger.GetComponent<StageManger>().stage = 3;
            stageManger.GetComponent<StageManger>().diff = 1;
        }
        SceneManager.LoadScene("MainScene");
    }
}
