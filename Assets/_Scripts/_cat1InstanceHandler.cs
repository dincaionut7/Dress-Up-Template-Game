using UnityEngine;

public class _cat1InstanceHandler : MonoBehaviour
{


    private void OnDisable()
    {
        transform.Find("_hairContainer").gameObject.SetActive(false);
        transform.Find("_rochiiContainer").gameObject.SetActive(false);
        transform.Find("_topsContainer").gameObject.SetActive(false);
        transform.Find("_fusteContainer").gameObject.SetActive(false);
        transform.Find("_pantofiContainer").gameObject.SetActive(false);

    }

    private void OnEnable()
    {
        transform.Find("_hairContainer").gameObject.SetActive(true);
    }
}
