using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuleTxt : MonoBehaviour
{
    int stage;
    int diff;
    public Text ruleTxt;
    // Start is called before the first frame update
    void Start()
    {
        stage = StageManger.instance.stage;
        diff = StageManger.instance.diff;

        if (stage == 1)
        {
            ruleTxt.text += "같은 팀원 사진끼리 매칭\n";
        }
        else if (stage == 2)
        {
            ruleTxt.text += "같은 빼빼로 사진끼리 매칭\n";
        }
        else if (stage == 3)
        {
            ruleTxt.text += "팀원과 팀원이 좋아하는 빼빼로 매칭\n";
        }

        if (diff == 1)
        {
            ruleTxt.text += "보통 난이도\n";
        }
        else if (diff == 2)
        {
            ruleTxt.text += "5번 틀릴 시 셔플\n카드 공개 시간 감소\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
