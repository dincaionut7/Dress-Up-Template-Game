using System.Collections;
using UnityEngine;

using UnityEngine.UI;


public class _scrollHairRoom : MonoBehaviour
{
    private RectTransform rectT;

    public Button left;
    public Button right;

    private void Start()
    {
        rectT = GetComponent<RectTransform>();
        Vector3 startpos = new Vector2(0, -185f);
        rectT.anchoredPosition = startpos;
    }



    void Update()
    {

        if (rectT.anchoredPosition.x < -6000)
        {
            right.interactable = false;
        }
        else
        {
            right.interactable = true;
        }

        if (rectT.anchoredPosition.x > -1)
        {
            left.interactable = false;
        }
        else
        {
            left.interactable = true;
        }

        if (rectT.anchoredPosition.x != -6300)
        {
            if (GameObject.Find("chenar"))
            {
                GameObject.Find("chenar").SetActive(false);
                GameObject.Find("placa_8").GetComponent<Toggle>().isOn = false;
            }
        }

    }

    public void scrollRight()
    {
        StartCoroutine(smoothScrollRight(rectT.anchoredPosition.x - 900));
    }

    public void scrollLeft()
    {
        StartCoroutine(smoothScrollLeft(rectT.anchoredPosition.x + 900));
    }

    IEnumerator smoothScrollRight(float endPos)
    {


        while (rectT.anchoredPosition.x != endPos)
        {
            right.enabled = false;
            rectT.anchoredPosition -= new Vector2(180, 0);
            yield return null;
        }
        right.enabled = true;

    }

    IEnumerator smoothScrollLeft(float endPos)
    {


        while (rectT.anchoredPosition.x != endPos)
        {
            left.enabled = false;
            rectT.anchoredPosition += new Vector2(180, 0);
            yield return null;
        }
        left.enabled = true;

    }
}
