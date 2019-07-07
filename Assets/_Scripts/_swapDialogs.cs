using UnityEngine;

public class _swapDialogs : MonoBehaviour {

    public GameObject nextDialog;


    private void Awake()
    {
        Invoke("onDisableDialog", 3.3f);
    }


    void onDisableDialog()
    {
        gameObject.SetActive(false);
        nextDialog.SetActive(true);   
    }
}
