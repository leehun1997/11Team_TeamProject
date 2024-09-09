using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx = 0;

    public GameObject front;
    public GameObject back;

    public Animator anim;

    public SpriteRenderer frontImage;

    public AudioClip clip;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Setting(int number)
    {
        idx = number;
        frontImage.sprite = Resources.Load<Sprite>($"rtan{idx}"); // Unity에서 기본 제공하는 Resources 함수를 이용하면 asset에 있는 Resources파일에 있는 자료와 상호작용할 수 있다. //$표시를 문자열 앞에 사용하면 {중괄호}를 사용하여서 원하는 값을 넣을 수 있다.        
    }
    public void openCard()
    {

        audioSource.PlayOneShot(clip); // play와 달리 playoneshot은 오디오 클립끼리 겹치지않는다.
        anim.SetBool("isOpen", true);
        front.SetActive(true);
        back.SetActive(false);

        if(GameManger.Instance.firstCard == null)
        {
            GameManger.Instance.firstCard = this;
        }
        else
        {
            GameManger.Instance.secondCard = this;
            GameManger.Instance.MatchCard();
        }
    }

    public void closeCard()
    {
        Invoke("closeCardInvoke", 1.0f);
    }
    public void closeCardInvoke()
    {
        anim.SetBool("isOpen", false);
        front.SetActive(false);
        back.SetActive(true);
    }

    public void DestroyCard()
    {
        Invoke("DestroyCardInvoke", 1.0f);
        GameManger.Instance.cardCount -= 1;
        if(GameManger.Instance.cardCount == 0)
        {
            GameManger.Instance.gameOver();
        }
    }
    public void DestroyCardInvoke()
    {
        Destroy(this.gameObject);
    }
}
