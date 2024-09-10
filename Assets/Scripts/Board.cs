using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Board : MonoBehaviour
{
    public GameObject card;
    public GameObject[] cardList;//수정한 줄
    // Start is called before the first frame update
    void Start()
    {
        cardList = new GameObject[16];//수정한 줄
        int[] arr = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        arr = arr.OrderBy(x=>Random.Range(0,7)).ToArray();
        for(int i = 0; i < 16; i++)
        {
            GameObject go = Instantiate(card, this.transform);

            float x = (i % 4) * 1.4f - 2.1f;
            float y = (i / 4) * 1.4f - 3.0f;

            go.transform.position = new Vector2(x, y);
            go.GetComponent<Card>().Setting(arr[i]);
            cardList[i] = go;//수정한 줄
        }
        GameManager.Instance.cardCount = arr.Length;
    }
    public void Shuffle()//수정한 줄~
    {

        int[] arr = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
        arr = arr.OrderBy(x => Random.Range(0, 15)).ToArray();
        for (int i = 0; i < 16; i++)
        {

            float x = (i % 4) * 1.4f - 2.1f;//-2.1,-0.7,+0.7,2.1
            float y = (i / 4) * 1.4f - 3.0f;//-3.0,-1.6,-0.2,1.2

            if(cardList[arr[i]]!=null)cardList[arr[i]].transform.position = new Vector2(x, y);
        }
        
    }//~수정한 줄
}
