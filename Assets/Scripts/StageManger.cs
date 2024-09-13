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

            PlayerPrefs.DeleteAll(); //playerfebs √ ±‚»≠
            if (!PlayerPrefs.HasKey("maxStage"))
            {                
                PlayerPrefs.SetInt("maxStage", -1);
            }
            if (!PlayerPrefs.HasKey("clearStage"))
            {
                PlayerPrefs.SetInt("clearStage", 0);
            }

            else
            {
                checkClearStage();       
            }
        }
        else
        {
            Destroy(gameObject);
        }        
    }

    private void Update()
    {
        checkClearStage();
    }
    void checkClearStage()
    {
        for (int i = 1; i <= PlayerPrefs.GetInt("clearStage"); i++)
        {
            string name = $"clearStage{i}";
            if (name == "clearStage1")
            {
                clearStage1 = true;
            }
            else if (name == "clearStage2")
            {
                clearStage2 = true;
            }
            else if (name == "clearStage3")
            {
                clearStage3 = true;
            }
            else if (name == "clearStage4")
            {
                clearStage4 = true;
            }
            else
            {
                return;
            }
        }
    }
}
