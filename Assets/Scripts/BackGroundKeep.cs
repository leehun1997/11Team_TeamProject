using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    //public static BackGround instance;
    private void Awake()
    {
        //if (instance == null)
        //{
        //    instance = this;
            DontDestroyOnLoad(gameObject);
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}
    }
}
