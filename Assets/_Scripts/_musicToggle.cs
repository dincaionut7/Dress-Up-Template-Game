using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _musicToggle : MonoBehaviour
{
    private bool musicState = true;
   
    public void OnValueChange()
    {
        if (GameObject.Find("_soundManager"))
        {
            if (musicState)
            {
                _soundManager.GetInstance().gameObject.GetComponent<AudioSource>().mute = true;
                musicState = false;
            }
            else
            {
                _soundManager.GetInstance().gameObject.GetComponent<AudioSource>().mute = false;
                musicState = true;
            }
        }
    }
}
