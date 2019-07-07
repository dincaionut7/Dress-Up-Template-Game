using UnityEngine;

using UnityEngine.UI;

public class _blushZone : MonoBehaviour
{

    public _data data;
    public bool filled = false;

    private Image imgBlush;
    private Collider2D tempC;
   

    private void Start()
    {
        imgBlush = transform.Find("blush_actual").GetComponent<Image>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "remover")
        {
            Color tempColor = imgBlush.color;
            tempColor.a = 0.0f;
            imgBlush.color = tempColor;

            data.blushDressup = null;
            data.blushMakeup = null;
        }

        if (collision != tempC)
        {
            if (collision.gameObject.tag == "brushBlush")
            {
                if (filled)
                    return;
                data.blushMakeup = collision.gameObject.GetComponent<_draggingHandler>().toSwap;
                data.blushDressup = collision.gameObject.GetComponent<_draggingHandler>().toSwapDressup;
                Color tempColor = imgBlush.color;
                tempColor.a = 0.1f;
                imgBlush.color = tempColor;

            }
        }

        tempC = collision;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "brushBlush" && collision.gameObject.GetComponent<_draggingHandler>()._moving == true)
        {
            GameObject.Find("fillPercentage").GetComponent<Image>().enabled = true;
            GameObject.Find("fillPercentage").GetComponent<Image>().fillAmount = imgBlush.color.a;

            Color tempColor = imgBlush.color;
            if (tempColor.a >= 1f)
            {
                filled = true;
                return;
            }
            tempColor.a += 0.01f;
            imgBlush.color = tempColor;
        }

    }



}
