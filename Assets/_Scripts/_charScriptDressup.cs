using UnityEngine;

using UnityEngine.UI;

public class _charScriptDressup : MonoBehaviour
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
    private GameObject rochie;
    private GameObject top;
    private GameObject skirt;
    private GameObject shoes;
    private GameObject poseta;
    private GameObject tiarra;
    private GameObject pants;
    private GameObject gloves;
    private GameObject ear;
    private GameObject neck;

    private void Start()
    {
        hair = transform.Find("hair").gameObject;
        eyes = transform.Find("ochi").gameObject;
        eyebrows = transform.Find("sprancene").gameObject;
        lips = transform.Find("lips").gameObject;
        eyeleashes = transform.Find("gene").gameObject;
        fard = transform.Find("fard").gameObject;
        blush = transform.Find("blush").gameObject;
        tus = transform.Find("tus").gameObject;
        gloss = transform.Find("gloss").gameObject;
        rochie = transform.Find("rochie_p").gameObject;
        top = transform.Find("top").gameObject;
        skirt = transform.Find("fusta").gameObject;
        shoes = transform.Find("pantofi").gameObject;
        poseta = transform.Find("poseta").gameObject;
        tiarra = transform.Find("tiarra").gameObject;
        pants = transform.Find("pants").gameObject;
        gloves = transform.Find("gloves").gameObject;
        ear = transform.Find("ears").gameObject;
        neck = transform.Find("neck").gameObject;

    }

    private void Update()
    {
        hair.GetComponent<Image>().sprite = data.parDressup;
        eyes.GetComponent<Image>().sprite = data.ochiDressup;
        eyebrows.GetComponent<Image>().sprite = data.spranceneDressup;
        lips.GetComponent<Image>().sprite = data.rujDressup;
        eyeleashes.GetComponent<Image>().sprite = data.geneDressup;



        if (data.fardDressup)
        {
            fard.GetComponent<Image>().sprite = data.fardDressup;
            fard.SetActive(true);
        }
        else
        {
            fard.SetActive(false);
        }


        if (data.blushDressup)
        {
            blush.GetComponent<Image>().sprite = data.blushDressup;
            tus.SetActive(true);
        }
        else
        {
            blush.SetActive(false);
        }


        if (data.tusDressup)
        {
            tus.GetComponent<Image>().sprite = data.tusDressup;
            tus.SetActive(true);
        }
        else
        {
            tus.SetActive(false);
        }


        if (data.glossDressup)
        {
            gloss.GetComponent<Image>().sprite = data.glossDressup;
            gloss.SetActive(true);
        }
        else
        {
            gloss.SetActive(false);
        }


        if (data.rochie)
        {
            rochie.GetComponent<Image>().sprite = data.rochie;
            rochie.SetActive(true);
        }
        else
        {
            rochie.SetActive(false);
        }


        if (data.top)
        {
            top.GetComponent<Image>().sprite = data.top;
            top.SetActive(true);
        }
        else
        {
            top.SetActive(false);
        }


        if (data.skirt)
        {
            skirt.GetComponent<Image>().sprite = data.skirt;
            skirt.SetActive(true);
        }
        else
        {
            skirt.SetActive(false);
        }


        if (data.pantofi)
        {
            shoes.GetComponent<Image>().sprite = data.pantofi;
            shoes.SetActive(true);
        }
        else
        {
            shoes.SetActive(false);
        }


        if (data.bag)
        {
            poseta.GetComponent<Image>().sprite = data.bag;
            poseta.SetActive(true);
        }
        else
        {
            poseta.SetActive(false);
        }


        if (data.tiarra)
        {
            tiarra.GetComponent<Image>().sprite = data.tiarra;
            tiarra.SetActive(true);
        }
        else
        {
            tiarra.SetActive(false);
        }


        if (data.pants)
        {
            pants.GetComponent<Image>().sprite = data.pants;
            pants.SetActive(true);
        }
        else
        {
            pants.SetActive(false);
        }

        if (data.gloves)
        {
            gloves.GetComponent<Image>().sprite = data.gloves;
            gloves.SetActive(true);
        }
        else
        {
            gloves.SetActive(false);
        }

        if (data.ear)
        {
            ear.GetComponent<Image>().sprite = data.ear;
            ear.SetActive(true);
        }
        else
        {
            ear.SetActive(false);
        }

        if (data.neck)
        {
            neck.GetComponent<Image>().sprite = data.neck;
            neck.SetActive(true);
        }
        else
        {
            neck.SetActive(false);
        }



    }


}
