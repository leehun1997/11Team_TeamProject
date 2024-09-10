using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundBtnManger : MonoBehaviour
{
    GameObject stagemanger;

    public Button roundbtn2;
    public Button roundbtn3;
    public Button roundbtn4;
    public GameObject roundbtn5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stagemanger = GameObject.Find("StageManger");
        if (stagemanger.GetComponent<StageManger>().clearStage1 == true)
        {
            roundbtn2.GetComponent<Button>().interactable = true;
        }
        if (stagemanger.GetComponent<StageManger>().clearStage2 == true)
        {
            roundbtn3.GetComponent<Button>().interactable = true;
        }
        if (stagemanger.GetComponent<StageManger>().clearStage3 == true)
        {
            roundbtn4.GetComponent<Button>().interactable = true;
        }
        if (stagemanger.GetComponent<StageManger>().clearStage4 == true)
        {
            roundbtn5.GetComponent<GameObject>().SetActive(true);
        }
    }
}
