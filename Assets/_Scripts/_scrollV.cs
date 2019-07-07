using System.Collections;
using UnityEngine;

using UnityEngine.UI;

public class _scrollV : MonoBehaviour
{
    private RectTransform rectT;

    public Button up;
    public Button down;

    private void Start()
    {
        rectT = GetComponent<RectTransform>();
        Vector3 startpos = new Vector2(rectT.anchoredPosition.x, 350);
        rectT.anchoredPosition = startpos;
    }




    void Update()
    {
        rectT = GetComponent<RectTransform>();

        if (rectT.anchoredPosition.y < 360)
        {
            up.interactable = false;
        }
        else
        {
            up.interactable = true;
        }

        if (rectT.anchoredPosition.y > 1900)
        {
            down.interactable = false;
        }
        else
        {
            down.interactable = true;
        }


    }

    public void scrollUp()
    {
        if (gameObject.activeSelf == false)
        {
            return;
        }

        StartCoroutine(smoothScrollUp(rectT.anchoredPosition.y - 200));
    }

    public void scrollDown()
    {
        if (gameObject.activeSelf == false)
        {
            return;
        }

        StartCoroutine(smoothScrollDown(rectT.anchoredPosition.y + 200));
    }

    IEnumerator smoothScrollUp(float endPos)
    {


        while (rectT.anchoredPosition.y != endPos)
        {
            up.enabled = false;
            if (rectT.anchoredPosition.y <= endPos + 5f)
            {
                rectT.anchoredPosition -= new Vector2(0, 5f);
                yield return null;
            }
            else
            {
                rectT.anchoredPosition -= new Vector2(0, 20f);
                yield return null;
            }
        }
        up.enabled = true;

    }

    IEnumerator smoothScrollDown(float endPos)
    {


        while (rectT.anchoredPosition.y != endPos)
        {
            down.enabled = false;
            if (rectT.anchoredPosition.y >= endPos + 20)
            {
                rectT.anchoredPosition += new Vector2(0, 5f);
                yield return null;
            }
            else
            {
                rectT.anchoredPosition += new Vector2(0, 20f);
                yield return null;
            }
        }
        down.enabled = true;

    }

    private void OnDisable()
    {
        rectT.anchoredPosition = new Vector2(rectT.anchoredPosition.x, 350);
    }
}
