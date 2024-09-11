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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stagemanger = GameObject.Find("StageManger");
        if (stagemanger.GetComponent<StageManger>().clearStage1 == true)
        {
            roundbtn1.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn2.GetComponent<Button>().interactable = true;
            roundbtn2.transform.GetChild(1).GetComponent<Animator>().SetBool("clearStage1", true);
        }
        if (stagemanger.GetComponent<StageManger>().clearStage2 == true)
        {
            roundbtn2.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn3.GetComponent<Button>().interactable = true;
            roundbtn3.transform.GetChild(1).GetComponent<Animator>().SetBool("clearStage2", true);
        }
        if (stagemanger.GetComponent<StageManger>().clearStage3 == true)
        {
            roundbtn3.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn4.GetComponent<Button>().interactable = true;
            roundbtn4.transform.GetChild(1).GetComponent<Animator>().SetBool("clearStage3", true);
        }
        if (stagemanger.GetComponent<StageManger>().clearStage4 == true)
        {
            roundbtn4.transform.GetChild(1).GetComponent<Image>().enabled = false;
            roundbtn5.SetActive(true);
        }
    }
}
