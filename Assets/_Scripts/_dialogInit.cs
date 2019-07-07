using UnityEngine;

public class _dialogInit : MonoBehaviour {

    public GameObject dialogtoInit;

    private void Awake()
    {
        Invoke("dialogInitialize", 0.5f);   
    }

    void dialogInitialize()
    {
        dialogtoInit.SetActive(true);
    }
}
