using UnityEngine;

public class _cat1ContainersDisabler : MonoBehaviour
{
    private void OnDisable()
    {
        transform.Find("frizura").GetComponent<_catInstanceButton>().on = true;
        transform.Find("rochii").GetComponent<_catInstanceButton>().on = false;
        transform.Find("top").GetComponent<_catInstanceButton>().on = false;
        transform.Find("fuste").GetComponent<_catInstanceButton>().on = false;
        transform.Find("pantofi").GetComponent<_catInstanceButton>().on = false;

    }

}
