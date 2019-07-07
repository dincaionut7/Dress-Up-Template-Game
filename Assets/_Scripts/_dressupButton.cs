using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class _dressupButton : MonoBehaviour, IDeselectHandler
{
    public _data data;
   

    public Sprite toSwap;
    public Sprite toSwapMakeup;


    private Button button;

    private void Update()
    {
        if (toSwap == data.parDressup ||
            toSwap == data.pantofi ||
            toSwap == data.skirt ||
            toSwap == data.rochie ||
            toSwap == data.neck ||
            toSwap == data.bag || 
            toSwap == data.gloves ||
            toSwap == data.ear ||
            toSwap == data.tiarra ||
            toSwap == data.pants)
        {
            transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
        }
        else
        {
            transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
        }

        if (GameObject.Find("_bff1"))
        {
            data = GameObject.Find("_bff1").GetComponent<_bffScript>().data;
        }
        else if (GameObject.Find("_bff2"))
        {
            data = GameObject.Find("_bff2").GetComponent<_bffScript>().data;
        }
        else if (GameObject.Find("_bff3"))
        {
            data = GameObject.Find("_bff3").GetComponent<_bffScript>().data;
        }


    }


    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(onClick);

    }

    protected void onClick()
    {
        if (gameObject.tag == "hairButton")
        {
            if (data.parDressup == toSwap)
            {
               // transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.parDressup = data.parDefaultDressup;
                data.parMakeup = data.parDefault;
            }
            else
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.parDressup = toSwap;
                data.parMakeup = toSwapMakeup;
            }
        }

        if (gameObject.tag == "dressButton")
        {
            data.top = null;
            data.skirt = null;

            if (data.rochie == toSwap)
            {
               // transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.rochie = null;
            }
            else
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.rochie = toSwap;
            }
        }

        if (gameObject.tag == "topButton")
        {
            data.rochie = null;

            if (data.top == toSwap)
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.top = null;
            }
            else
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.top = toSwap;
            }
        }

        if (gameObject.tag == "skirtButton")
        {
            data.rochie = null;

            if (data.skirt == toSwap)
            {
               // transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.skirt = null;
            }
            else
            {
               // transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.skirt = toSwap;
            }
        }

        if (gameObject.tag == "shoesButton")
        {

            if (data.pantofi == toSwap)
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.pantofi = null;
            }
            else
            {
               // transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.pantofi = toSwap;
            }
        }

        if (gameObject.tag == "bagsButton")
        {

            if (data.bag == toSwap)
            {
             //   transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.bag = null;
            }
            else
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.bag = toSwap;
            }
        }

        if (gameObject.tag == "tiarraButton")
        {
            if (data.tiarra == toSwap)
            {
               // transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.tiarra = null;
            }
            else
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.tiarra = toSwap;
            }
        }

        if (gameObject.tag == "pantsButton")
        {
            if (data.pants == toSwap)
            {
             //   transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.pants = null;
            }
            else
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.pants = toSwap;
            }
        }

        if (gameObject.tag == "glovesButton")
        {
            if (data.gloves == toSwap)
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.gloves = null;
            }
            else
            {
              //  transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.gloves = toSwap;
            }
        }


        if (gameObject.tag == "neckButton")
        {
            if (data.neck == toSwap)
            {
             //   transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.neck = null;
            }
            else
            {
               // transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.neck = toSwap;
            }
        }

        if (gameObject.tag == "earButton")
        {
            if (data.ear == toSwap)
            {
                //   transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
                data.ear = null;
            }
            else
            {
                // transform.parent.Find("highlight").GetComponent<Image>().enabled = true;
                data.ear = toSwap;
            }
        }
    }

    public void OnDeselect(BaseEventData data)
    {
      //  transform.parent.Find("highlight").GetComponent<Image>().enabled = false;
    }


}
