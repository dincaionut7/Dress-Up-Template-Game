using UnityEngine;

using UnityEngine.UI;

public class _charScript : MonoBehaviour
{
    public _data data;

    private GameObject hair;
    private GameObject eyes;
    private GameObject eyebrows;
    private GameObject lips;
    private GameObject eyeleashes;
    private GameObject fard;
    private GameObject blush;
    private GameObject tus;
    private GameObject gloss;

    private void Start()
    {
        hair = transform.Find("hair").gameObject;
        eyes = transform.Find("eyes").gameObject;
        eyebrows = transform.Find("eyebrows").gameObject;
        lips = transform.Find("lips_default").Find("lips").gameObject;
        eyeleashes = transform.Find("eyes").Find("eyeleashes_ochi").gameObject;
        fard = transform.Find("eyes").Find("fard_ochi").gameObject;
        blush = transform.Find("blush_char").Find("blush_actual").gameObject;
        tus = transform.Find("eyes").Find("tus_ochi").gameObject;
        gloss = transform.Find("lips_default").Find("gloss_actual").gameObject;
    }


    private void Update()
    {
        hair.GetComponent<Image>().sprite = data.parMakeup;
        eyes.GetComponent<Image>().sprite = data.ochiMakeup;
        eyebrows.GetComponent<Image>().sprite = data.spranceneMakeup;
        lips.GetComponent<Image>().sprite = data.rujMakeup;
        eyeleashes.GetComponent<Image>().sprite = data.geneMakeup;
        fard.GetComponent<Image>().sprite = data.fardMakeup;
        blush.GetComponent<Image>().sprite = data.blushMakeup;
        tus.GetComponent<Image>().sprite = data.tusMakeup;
        gloss.GetComponent<Image>().sprite = data.glossMakeup;

        if (!data.rujMakeup)
        {
            lips.GetComponent<Image>().enabled = false;
        }
        else
        {
            lips.GetComponent<Image>().enabled = true;
        }

        if (!data.fardMakeup)
        {
            fard.SetActive(false);
        }
        else
        {
            fard.SetActive(true);
        }

        if (!data.blushMakeup)
        {
            blush.SetActive(false);
        }
        else
        {
            blush.SetActive(true);
        }

        if (!data.tusMakeup)
        {
            tus.SetActive(false);
        }
        else
        {
            tus.SetActive(true);
        }

        if (!data.glossMakeup)
        {
            gloss.SetActive(false);
        }
        else
        {
            gloss.SetActive(true);
        }
    }

}
