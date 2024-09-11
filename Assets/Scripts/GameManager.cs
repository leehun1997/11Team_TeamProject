using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject stagemanger;
    public static GameManager Instance;
    public Board board;//수정한 줄
    public Card firstCard;
    public Card secondCard;
    public TimeBar timeBar;
    public GameObject stopBtn;
    int stage;
    int diff;

    public float time;

    public Text timeTxt;
    public GameObject endingUI1;
    public GameObject endingUI2;
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
        timeBar.gameObject.SetActive(true);
        time = 30.0f;
        stagemanger = GameObject.Find("StageManger");
        stage = stagemanger.GetComponent<StageManger>().stage;
        diff = stagemanger.GetComponent<StageManger>().diff;
        Time.timeScale = 1.0f;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeBar.SetGauge(0, 30, time);
        timeTxt.text = time.ToString("N2");

        if (time < 0f)
        {
            GameOut();
        }
    }
    public void Matched()
    {
        if (stage != 3) { 
            if(firstCard.idx == secondCard.idx)
            {
                audioSource.PlayOneShot(clip);
                firstCard.DestroyCard();
                secondCard.DestroyCard();
                cardCount -= 2;
                if(cardCount==0 )
                {
                    Time.timeScale = 0.0f;
                    timeBar.gameObject.SetActive(false);
                    stopBtn.gameObject.SetActive(false);
                    finishUi.gameClear();
                    finishUi.ServiceView();
                    endingUI1.SetActive(true);
                    endingUI2.SetActive(true);
                }
            }
            else
            {
                firstCard.CloseCard();
                secondCard.CloseCard();
                    if (diff == 2)
                {
                    failCount += 1;
                }
                if (failCount == 5)
                {
                    StartCoroutine(WaitForShuffle(0.5f));
                    failCount = 0;
                }//~수정한 줄
            }
        firstCard = null;
        secondCard = null;
        }
        else if (stage == 3)
        {
            HiddenMatch();
        }
    }
    public void GameOut()
    {
        Time.timeScale = 0.0f;
        timeBar.gameObject.SetActive(false);
        stopBtn.gameObject.SetActive(false);
        finishUi.gameFail();
        endingUI1.SetActive(true);
    }
    public void HiddenMatch()
    {
        if (HiddenMatchResult())
        {
            audioSource.PlayOneShot(clip);
            firstCard.DestroyCard();
            secondCard.DestroyCard();
            cardCount -= 2;
            if (cardCount == 0)
            {
                Time.timeScale = 0.0f;
                timeBar.gameObject.SetActive(false);
                stopBtn.gameObject.SetActive(false);
                finishUi.gameClear();
                finishUi.ServiceView();
                endingUI1.SetActive(true);
                endingUI2.SetActive(true);
            }
        }
        else
        {
            firstCard.CloseCard();
            secondCard.CloseCard();
            if (diff == 2)
            {
                failCount += 1;
            }
            if (failCount == 5)
            {
                StartCoroutine(WaitForShuffle(0.5f));
                failCount = 0;
            }//~수정한 줄
        }
        firstCard = null;
        secondCard = null;
    }
    public bool HiddenMatchResult()
    {
        if (firstCard.idx == 0||firstCard.idx==1)//cis,kihyeok,leehun,seo 순서
        {
            if (secondCard.idx ==12||secondCard.idx==13) { return true; }
        }
        if (firstCard.idx == 2 || firstCard.idx == 3)
        {
            if (secondCard.idx ==10|| secondCard.idx ==14) { return true; }
        }
        if (firstCard.idx == 4 || firstCard.idx == 5)
        {
            if (secondCard.idx ==8|| secondCard.idx ==9) { return true; }
        }
        if (firstCard.idx == 6 || firstCard.idx == 7)
        {
            if (secondCard.idx ==11|| secondCard.idx ==15) { return true; }
        }
        if (firstCard.idx == 12 || firstCard.idx == 13)
        {
            if (secondCard.idx ==0|| secondCard.idx ==1) { return true; }
        }
        if (firstCard.idx == 10 || firstCard.idx == 14)
        {
            if (secondCard.idx ==2|| secondCard.idx ==3) { return true; }
        }
        if (firstCard.idx == 8 || firstCard.idx == 9)
        {
            if (secondCard.idx ==4|| secondCard.idx ==5) { return true; }
        }
        if (firstCard.idx == 11 || firstCard.idx == 15)
        {
            if (secondCard.idx ==6|| secondCard.idx ==7) { return true; }
        }
        return false;
    }
    IEnumerator WaitForShuffle(float delayTime)//수정한 줄~
    {
        yield return new WaitForSeconds(delayTime);
        board.Shuffle();
    }//~수정한 줄
}
