using UnityEngine;

using UnityEngine.UI;

public class _lipsZone : MonoBehaviour
{
    
    public _data data;

    private Image imgRuj;
    private Image imgGloss;
    private Collider2D tempC;
    public bool filled = false;

    private void Start()
    {
        imgRuj = GetComponent<Image>();
        imgGloss = transform.parent.transform.Find("gloss_actual").GetComponent<Image>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "remover")
        {
            Color tempColor1 = imgRuj.color;
            Color tempColor2 = imgGloss.color;
            tempColor1.a = 0.0f;
            tempColor2.a = 0.0f;
            imgRuj.color = tempColor1;
            imgGloss.color = tempColor2;

            data.rujDressup = data.rujDefaultDressup;
            data.glossDressup = null;
            data.glossMakeup = null;
            data.rujMakeup = data.rujDefault;
 
        }

        if (collision != tempC)
        {
            if (collision.gameObject.tag == "ruj")
            {
                if (filled)
                    return;
                data.rujMakeup = collision.gameObject.GetComponent<_draggingHandler>().toSwap;
                data.rujDressup = collision.gameObject.GetComponent<_draggingHandler>().toSwapDressup;
                Color tempColor = imgRuj.color;
                tempColor.a = 0.1f;
                imgRuj.color = tempColor;
                
            }

            if (collision.gameObject.tag == "brushGloss")
            {
                if (filled)
                    return;
                data.glossMakeup = collision.gameObject.GetComponent<_draggingHandler>().toSwap;
                data.glossDressup = collision.gameObject.GetComponent<_draggingHandler>().toSwapDressup;
                Color tempColor = imgGloss.color;
                tempColor.a = 0.1f;
                imgGloss.color = tempColor;

            }
        }

        tempC = collision;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
       
   
        if (collision.gameObject.tag == "ruj" && collision.gameObject.GetComponent<_draggingHandler>()._moving == true)
        {
            GameObject.Find("fillPercentage").GetComponent<Image>().enabled = true;
            GameObject.Find("fillPercentage").GetComponent<Image>().fillAmount = imgRuj.color.a;

            Color tempColor = imgRuj.color;
            if (tempColor.a >= 1f)
            {
                filled = true;
                return;
            }
            tempColor.a += 0.01f;
            imgRuj.color = tempColor;
        }

        if (collision.gameObject.tag == "brushGloss" && collision.gameObject.GetComponent<_draggingHandler>()._moving == true)
        {
            GameObject.Find("fillPercentage").GetComponent<Image>().enabled = true;
            GameObject.Find("fillPercentage").GetComponent<Image>().fillAmount = imgGloss.color.a;

            Color tempColor = imgGloss.color;
            if (tempColor.a >= 1f)
            {
                filled = true;
                return;
            }
            tempColor.a += 0.01f;
            imgGloss.color = tempColor;
        }


    }

}

