using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour
{
    public static AudioManger Instance;

    public AudioClip clip;
    AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject); // scene을 이동해도 audioManger가 파괴되지않음.
        }
        else // 싱글톤의 활용 : 만약에 scene을 이동하면서 2개의 audioManger가 만들어지면 , 2번째 audioManger가 스스로를 파괴한다.
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
