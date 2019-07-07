using UnityEngine;

using UnityEngine.UI;

public class _eyeZone : MonoBehaviour
{
    public _data data;

    public bool filled = false;
    private Collider2D tempC;
    private Image imgFard;
    private Image imgTus;

    private void Start()
    {
        imgFard = transform.Find("fard_ochi").GetComponent<Image>();
        imgTus = transform.Find("tus_ochi").GetComponent<Image>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "remover")
        {
            Color tempColor1 = imgFard.color;
            Color tempColor2 = imgTus.color;
            tempColor1.a = 0.0f;
            tempColor2.a = 0.0f;
            imgFard.color = tempColor1;
            imgTus.color = tempColor2;

            data.spranceneMakeup = data.spranceneDefault;
            data.spranceneDressup = data.spranceneDefaultDressup;
           
            data.ochiMakeup = data.ochiDefault;
            data.ochiDressup = data.ochiDefaultDressup;

            data.geneMakeup = data.geneDefault;
            data.geneDressup = data.geneDefaultDressup;

            data.fardDressup = null;
            data.tusDressup = null;
            data.fardMakeup = null;
            data.tusMakeup = null;
            
        }


        if (collision != tempC)
        {
            if (collision.gameObject.tag == "brushFard")
            {
                if (filled)
                    return;
                data.fardMakeup = collision.GetComponent<_draggingHandler>().toSwap;
                data.fardDressup = collision.GetComponent<_draggingHandler>().toSwapDressup;
                Color tempColor = imgFard.color;
                tempColor.a = 0.1f;
                imgFard.color = tempColor;
            }

            if (collision.gameObject.tag == "brushTus")
            {
                if (filled)
                    return;
                data.tusMakeup = collision.GetComponent<_draggingHandler>().toSwap;
                data.tusDressup = collision.GetComponent<_draggingHandler>().toSwapDressup;
                Color tempColor = imgTus.color;
                tempColor.a = 0.0f;
                imgTus.color = tempColor;
            }

            if (collision.gameObject.tag == "sprancene")
            {
                if (filled)
                    return;
                data.spranceneMakeup = collision.GetComponent<_draggingHandler>().toSwap;
                data.spranceneDressup = collision.GetComponent<_draggingHandler>().toSwapDressup;
            }

            if (collision.gameObject.tag == "brushRimel")
            {
                if (filled)
                    return;
                data.geneMakeup = collision.GetComponent<_draggingHandler>().toSwap;
                data.geneDressup = collision.GetComponent<_draggingHandler>().toSwapDressup;
            }
        }
        tempC = collision;

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "brushFard" && collision.gameObject.GetComponent<_draggingHandler>()._moving == true)
        {
            GameObject.Find("fillPercentage").GetComponent<Image>().enabled = true;
            GameObject.Find("fillPercentage").GetComponent<Image>().fillAmount = imgFard.color.a;

            Color tempColor = imgFard.color;
            if (tempColor.a >= 1f)
            {
                filled = true;
            }
            tempColor.a += 0.02f;
            imgFard.color = tempColor;
        }

        if (collision.gameObject.tag == "brushTus" && collision.gameObject.GetComponent<_draggingHandler>()._moving == true)
        {
            GameObject.Find("fillPercentage").GetComponent<Image>().enabled = true;
            GameObject.Find("fillPercentage").GetComponent<Image>().fillAmount = imgTus.color.a;

            Color tempColor = imgTus.color;
            if (tempColor.a >= 1f)
            {
                filled = true;
            }
            tempColor.a += 0.01f;
            imgTus.color = tempColor;
        }

       
    }



}
