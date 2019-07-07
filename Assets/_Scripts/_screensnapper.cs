using UnityEngine;

using UnityEngine.UI;

public class _screensnapper : MonoBehaviour {

    public GameObject setButton;
    public GameObject bffButton;
    public GameObject snapshotButton;
    public GameObject backButton;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        disableUI();
        screenCapture();
        Invoke("enableUI", 0.5f);


    }

    public void screenCapture()
    {
        ScreenCapture.CaptureScreenshot("snapshot_bff.png");
    }

    public void disableUI()
    {
        setButton.SetActive(false);
        bffButton.SetActive(false);
        snapshotButton.SetActive(false);
        backButton.SetActive(false);
    }

    public void enableUI()
    {
        setButton.SetActive(true);
        bffButton.SetActive(true);
        snapshotButton.SetActive(true);
        backButton.SetActive(true);
    }
    

}
