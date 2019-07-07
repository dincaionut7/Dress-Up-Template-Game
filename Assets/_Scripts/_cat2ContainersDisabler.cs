using UnityEngine;

public class _cat2ContainersDisabler : MonoBehaviour
{
    private void OnDisable()
    {
        transform.Find("posete").GetComponent<_catInstanceButton>().on = true;
        transform.Find("coronite").GetComponent<_catInstanceButton>().on = false;
        transform.Find("colanti").GetComponent<_catInstanceButton>().on = false;
        transform.Find("manusi").GetComponent<_catInstanceButton>().on = false;
        transform.Find("bijuterii").GetComponent<_catInstanceButton>().on = false; 

    }

}
