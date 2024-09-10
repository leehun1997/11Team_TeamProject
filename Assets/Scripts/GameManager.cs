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
    int stage;
    int diff;

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
        stagemanger = GameObject.Find("StageManger");
        stage = stagemanger.GetComponent<StageManger>().stage;
        diff = stagemanger.GetComponent<StageManger>().diff;
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
                finishUi.ServiceView();
                image.SetActive(true);
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
