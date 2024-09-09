using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject card;


    // Start is called before the first frame update
    void Start()
    {
        int[] arr = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        arr = arr.OrderBy(x => Random.Range(0.0f, 7.0f)).ToArray(); //�Ź� �������� �������� �����Ѵ� == ���������� �����ϰڴ�.
        
        for (int i = 0; i < 16; i++)
        {
            float x = (i / 4) * 1.4f - 2.1f;
            float y = (i % 4) * 1.4f - 3.0f;
            GameObject c = Instantiate(card, this.transform); //instantiate �ڿ� ������ �߰��ϸ� �����ϴ� ��ġ�� ���� �� �ִ�.
            c.transform.position = new Vector2(x,y);

            c.GetComponent<Card>().Setting(arr[i]);
            
        }
        GameManger.Instance.cardCount = arr.Length;
    }
}
