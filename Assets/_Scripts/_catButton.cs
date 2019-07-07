using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class _catButton : MonoBehaviour
{
    public GameObject cat1;
    public GameObject cat2;

    public GameObject cat1_scroll;
    public GameObject cat2_scroll;

    private Toggle toggle;

	void Start ()
    {
        toggle = GetComponent<Toggle>();
	}
	
	
	void Update ()
    {
        if (toggle.isOn)
        {
            cat1.SetActive(true);
            cat1_scroll.SetActive(true);
            cat2.SetActive(false);
            cat2_scroll.SetActive(false);
            
        }
        else
        {
            cat1.SetActive(false);
            cat1_scroll.SetActive(false);
            cat2.SetActive(true);
            cat2_scroll.SetActive(true);
        }
	}
}
