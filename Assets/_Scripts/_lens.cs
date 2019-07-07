using UnityEngine;

using UnityEngine.UI;


public class _lens : MonoBehaviour
{
    public _data data;
    public Sprite toSwap;
    public Sprite toSwapDressup;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SwapLens);
    }


    void SwapLens()
    {
        if (data.ochiMakeup == toSwap)
        {
            data.ochiMakeup = data.ochiDefault;
            data.ochiDressup = data.ochiDefaultDressup;
        }
        else
        {
            data.ochiMakeup = toSwap;
            data.ochiDressup = toSwapDressup;
        }
    }

}
