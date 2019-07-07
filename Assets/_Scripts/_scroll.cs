using System.Collections;
using UnityEngine;

using UnityEngine.UI;


public class _scroll : MonoBehaviour
{
    private RectTransform rectT;

    public Button left;
    public Button right;

    private void Start()
    {
        rectT = GetComponent<RectTransform>();
        Vector3 startpos = new Vector2(5450, -210f);
        rectT.anchoredPosition = startpos;
    }



    void Update()
    {

        if (rectT.anchoredPosition.x < -5445)
        {
            right.interactable = false;
        }
        else
        {
            right.interactable = true;
        }

        if (rectT.anchoredPosition.x > 5445)
        {
            left.interactable = false;
        }
        else
        {
            left.interactable = true;
        }

        
    }

    public void scrollRight()
    {
        StartCoroutine(smoothScrollRight(rectT.anchoredPosition.x - 730));
    }

    public void scrollLeft()
    {
        StartCoroutine(smoothScrollLeft(rectT.anchoredPosition.x + 730));
    }

    IEnumerator smoothScrollRight(float endPos)
    {
        

        while (rectT.anchoredPosition.x != endPos)
        {
            right.enabled = false;
            rectT.anchoredPosition -= new Vector2(73, 0);
            yield return null;
        }
        right.enabled = true;

    }

    IEnumerator smoothScrollLeft(float endPos)
    {
        

        while (rectT.anchoredPosition.x != endPos)
        {
            left.enabled = false;
            rectT.anchoredPosition += new Vector2(73, 0);
            yield return null;
        }
        left.enabled = true;

    }
}
