using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _soundManager : MonoBehaviour {


    public static _soundManager instance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public static _soundManager GetInstance()
    {
        return instance;
    }
}
