using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    StageManger stageManger;
    AudioSource audioSource;
    public AudioClip clip;

    private void Awake()
    {
        if (instance == null)
        {
            stageManger = GameObject.Find("StageManger").GetComponent<StageManger>();
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = this.clip;
        audioSource.Play();
    }    
}
