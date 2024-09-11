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
            ruleTxt.text += "���� ���� �������� ��Ī\n";
        }
        else if (stage == 2)
        {
            ruleTxt.text += "���� ������ �������� ��Ī\n";
        }
        else if (stage == 3)
        {
            ruleTxt.text += "������ ������ �����ϴ� ������ ��Ī\n";
        }

        if (diff == 1)
        {
            ruleTxt.text += "���� ���̵�\n";
        }
        else if (diff == 2)
        {
            ruleTxt.text += "5�� Ʋ�� �� ����\nī�� ���� �ð� ����\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
