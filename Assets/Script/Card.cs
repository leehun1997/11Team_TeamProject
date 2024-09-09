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
        frontImage.sprite = Resources.Load<Sprite>($"rtan{idx}"); // Unity���� �⺻ �����ϴ� Resources �Լ��� �̿��ϸ� asset�� �ִ� Resources���Ͽ� �ִ� �ڷ�� ��ȣ�ۿ��� �� �ִ�. //$ǥ�ø� ���ڿ� �տ� ����ϸ� {�߰�ȣ}�� ����Ͽ��� ���ϴ� ���� ���� �� �ִ�.        
    }
    public void openCard()
    {

        audioSource.PlayOneShot(clip); // play�� �޸� playoneshot�� ����� Ŭ������ ��ġ���ʴ´�.
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
