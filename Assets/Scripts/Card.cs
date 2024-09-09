using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx = 0;
    public int stage = 0;
    public int diff = 0;

    public GameObject front;
    public GameObject back;

    public Animator anim;

    AudioSource audioSource;
    public AudioClip clip;

    public SpriteRenderer frontImage;
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
        if (stage == 1)
        {
            idx = number;
            int type = idx / 2;

            if (type == 0)
            {
                frontImage.sprite = Resources.Load<Sprite>($"cis{idx - (type * 2) + 1}");
            }
            else if (type == 1)
            {
                frontImage.sprite = Resources.Load<Sprite>($"KiHyeok{idx - (type * 2) + 1}");
            }
            else if (type == 2)
            {
                frontImage.sprite = Resources.Load<Sprite>($"LeeHun{idx - (type * 2) + 1}");
            }
            else if (type == 3)
            {
                frontImage.sprite = Resources.Load<Sprite>($"seo{idx - (type * 2) + 1}");
            }
        }
        else if (stage == 2)
        {
            idx = number;
            frontImage.sprite = Resources.Load<Sprite>($"Pepero{idx}");
        }
    }

    public void OpenCard()
    {
        if (Time.timeScale != 0f)
        {
            audioSource.PlayOneShot(clip);
            anim.SetBool("isOpen", true);
            front.SetActive(true);
            back.SetActive(false);

            if (GameManager.Instance.firstCard == null)
            {
                GameManager.Instance.firstCard = this;
            }
            else
            {
                GameManager.Instance.secondCard = this;
                GameManager.Instance.Matched();
            }

        }
    }
    public void DestroyCard()
    {
        Invoke("DestroyCardInvoke", 1.0f);
    }
    void DestroyCardInvoke()
    {
        Destroy(gameObject);
    }
    public void CloseCard()
    {
        if (diff == 1)
        {
            Invoke("CloseCardInvoke", 0.5f);
        }
        else if (diff == 2)
        {
            Invoke("CloseCardInvoke", 0.3f);
        }

    }
    void CloseCardInvoke()
    {
        anim.SetBool("isOpen", false);
        front.SetActive(false);
        back.SetActive(true);
    }
}
