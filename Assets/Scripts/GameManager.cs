using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Board board;//수정한 줄
    public Card firstCard;
    public Card secondCard;

    float time = 0.0f;

    public Text timeTxt;
    public GameObject image;
    public Finish finishUi;

    AudioSource audioSource;
    public AudioClip clip;

    public int cardCount = 0;
    public int failCount = 0;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");

        if (time > 30f)
        {
            GameOut();
        }
    }
    public void Matched()
    {
        if(firstCard.idx == secondCard.idx)
        {
            audioSource.PlayOneShot(clip);
            firstCard.DestroyCard();
            secondCard.DestroyCard();
            cardCount -= 2;
            if(cardCount==0 )
            {
                Time.timeScale = 0.0f;
                finishUi.gameClear();
                image.SetActive(true);
            }
        }
        else
        {
            firstCard.CloseCard();
            secondCard.CloseCard();
            failCount += 1;//수정한 줄~
            if (failCount == 5)
            {
                StartCoroutine(WaitForShuffle(0.5f));
                failCount = 0;
            }//~수정한 줄
        }
        firstCard = null;
        secondCard = null;
    }
    public void GameOut()
    {
        Time.timeScale = 0.0f;
        finishUi.gameFail();
        image.SetActive(true);
    }
    IEnumerator WaitForShuffle(float delayTime)//수정한 줄~
    {
        yield return new WaitForSeconds(delayTime);
        board.Shuffle();
    }//~수정한 줄
}
