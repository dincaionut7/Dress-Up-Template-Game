using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class _scrollButtons : MonoBehaviour , ISelectHandler
{

    public ScrollRect scroll;

    public void OnSelect(BaseEventData data)
    {
        initScroll();
    }

    void initScroll()
    {
        if (this.gameObject.name == "rightButton")
        {
            scroll.horizontalNormalizedPosition = scroll.horizontalNormalizedPosition + 0.17f;
        }
    }



}
