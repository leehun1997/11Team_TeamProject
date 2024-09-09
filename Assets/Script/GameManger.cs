using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    public Card firstCard;
    public Card secondCard;

    public Text timeTxt;
    public GameObject endTxt;

    public float time = 0.0f;
    public int cardCount = 0;

    public AudioClip clip;
    AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        Application.targetFrameRate = 60;
        Time.timeScale = 1.0f;        
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");
        if(time > 30.0f)
        {
            gameOver();
        }
    }

    public void gameOver()
    {
        endTxt.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void MatchCard()
    {
        if(firstCard.idx == secondCard.idx)
        {
            audioSource.PlayOneShot(clip);
            firstCard.DestroyCard();
            secondCard.DestroyCard();
            firstCard = null;
            secondCard = null;
        }
        else
        {
            firstCard.closeCard();
            secondCard.closeCard();
            firstCard = null;
            secondCard = null;
        }
    }
}
