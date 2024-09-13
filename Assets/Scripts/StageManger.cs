using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManger : MonoBehaviour
{
    public static StageManger instance;
    public int stage;
    public int diff;
    public int maxStage =- 1;

    public bool clearStage1 = false;
    public bool clearStage2 = false;
    public bool clearStage3 = false;
    public bool clearStage4 = false;
    public bool clearHidenStage = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }        
    }
}
