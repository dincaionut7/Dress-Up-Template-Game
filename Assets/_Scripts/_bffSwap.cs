using UnityEngine;

using UnityEngine.UI;

public class _bffSwap : MonoBehaviour
{

    public GameObject bff1;
    public GameObject bff2;
    public GameObject bff3;


    private int bffIndex;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        bffIndex = 1;

    }

    private void Update()
    {
        if (bffIndex > 3)
        {
            bffIndex = 1;
        }
    }

    public void OnClick()
    {

        if (bffIndex == 1)
        {
            bff1.SetActive(false);
            bff3.SetActive(false);
            bff2.SetActive(true);
            bffIndex++;
        }
        else if (bffIndex == 2)
        {
            bff1.SetActive(false);
            bff3.SetActive(true);
            bff2.SetActive(false);
            bffIndex++;
        }
        else if (bffIndex == 3)
        {
            bff1.SetActive(true);
            bff3.SetActive(false);
            bff2.SetActive(false);
            bffIndex++;
        }
    }
}
