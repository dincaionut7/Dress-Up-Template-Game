using UnityEngine;

using UnityEngine.UI;

public class _buttonPlaca : MonoBehaviour
{
    public Sprite toSwap;
    public Sprite toSwapDressup;

    public _data data;

    private Button button;
    
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(onClick);
    }

    public void onClick()
    {
        if (data.parMakeup == toSwap)
        {
            data.parMakeup = data.parDefault;
            data.parDressup = data.parDefaultDressup;
        }
        else
        {
            data.parMakeup = toSwap;
            data.parDressup = toSwapDressup;
        }
    }

}
