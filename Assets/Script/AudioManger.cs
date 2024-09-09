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
            DontDestroyOnLoad(gameObject); // scene�� �̵��ص� audioManger�� �ı���������.
        }
        else // �̱����� Ȱ�� : ���࿡ scene�� �̵��ϸ鼭 2���� audioManger�� ��������� , 2��° audioManger�� �����θ� �ı��Ѵ�.
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
