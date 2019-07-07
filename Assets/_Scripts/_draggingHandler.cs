
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;

public class _draggingHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Sprite toSwap;
    public Sprite toSwapDressup;
    public bool _moving = false;


    private Vector3 tf;
    private string parentName;
    private RectTransform rectT;



   float oldPos;

   void Start()
    {

       rectT = GetComponent<RectTransform>();
       oldPos = rectT.anchoredPosition.x;
    }

    void Update()
    {
        if (oldPos != rectT.anchoredPosition.x)
        {
            _moving = true;
        }
        else
        {
            _moving = false;
        }
        
        oldPos = rectT.anchoredPosition.x;
    }

    public void OnBeginDrag(PointerEventData data)
    {
        parentName = transform.parent.name;
        GameObject temp = GameObject.Find("Canvas");
        transform.SetParent(temp.transform);

        tf = transform.position;
        transform.position = Input.mousePosition + new Vector3 (0f, 25f, 0f);
        if (gameObject.tag == "brushFard" || gameObject.tag == "brushTus" || gameObject.tag == "brushRimel" || gameObject.tag == "brushBlush" || gameObject.tag == "brushGloss")
        {
            transform.Rotate(new Vector3(0, 0, 45));
        }

        if (gameObject.tag == "ruj" || gameObject.tag == "brushGloss")
        {
            GameObject.Find("pointerLips").GetComponent<Image>().enabled = true;
        }

        if (gameObject.tag == "brushFard" || gameObject.tag == "brushTus" || gameObject.tag == "brushRimel" || gameObject.tag == "sprancene")
        {
            GameObject.Find("pointerEyes").GetComponent<Image>().enabled = true;
        }

        if (gameObject.tag == "brushBlush")
        {
            GameObject.Find("pointerBlush").GetComponent<Image>().enabled = true;
        }

  

        
    }

    public void OnDrag(PointerEventData data)
    {
        transform.position = Input.mousePosition + new Vector3(0f, 25f, 0f);
    }

    public void OnEndDrag(PointerEventData data)
    {
        if (gameObject.tag == "ruj" || gameObject.tag == "brushFard" || gameObject.tag == "brushTus" || gameObject.tag == "sprancene" || gameObject.tag == "brushRimel" || gameObject.tag == "brushBlush" || gameObject.tag == "brushGloss")
        {
            GameObject.Find("lips").GetComponent<_lipsZone>().filled = false;
            GameObject.Find("eyes").GetComponent<_eyeZone>().filled = false;
            GameObject.Find("blush_char").GetComponent<_blushZone>().filled = false;

            GameObject.Find("pointerLips").GetComponent<Image>().enabled = false;
            GameObject.Find("pointerBlush").GetComponent<Image>().enabled = false;
            GameObject.Find("pointerEyes").GetComponent<Image>().enabled = false;
            GameObject.Find("fillPercentage").GetComponent<Image>().enabled = false;

        }
        GameObject temp = GameObject.Find(parentName);
        transform.SetParent(temp.transform);
        transform.position = tf;

        if (gameObject.tag == "brushFard" || gameObject.tag == "brushTus" || gameObject.tag == "brushRimel" || gameObject.tag == "brushSprancene" || gameObject.tag == "brushBlush" || gameObject.tag == "brushGloss")
        {
            transform.Rotate(new Vector3(0, 0, -45));
        }
    }

}
