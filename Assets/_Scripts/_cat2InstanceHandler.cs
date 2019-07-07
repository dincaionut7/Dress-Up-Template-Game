using UnityEngine;

public class _cat2InstanceHandler : MonoBehaviour
{


    private void OnDisable()
    {
        transform.Find("_bagContainer").gameObject.SetActive(false);
        transform.Find("_tiarraContainer").gameObject.SetActive(false);
        transform.Find("_pantsContainer").gameObject.SetActive(false);
        transform.Find("_glovesContainer").gameObject.SetActive(false);
        transform.Find("_jewleryContainer").gameObject.SetActive(false); 

    }

    private void OnEnable()
    {
        transform.Find("_bagContainer").gameObject.SetActive(true);
    }
}


