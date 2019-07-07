using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class _catInstanceButton : MonoBehaviour
{
    public bool on;

    public Sprite onState;
    public Sprite offState;

    public void stateON()
    {
        on = true;
    }

    public void stateOFF()
    {
        on = false;
 
    }

    private void Update()
    {
        if (on)
        {
            GetComponent<Image>().sprite = onState;
        }
        else
        {
            GetComponent<Image>().sprite = offState;
        }
    }
}
