using UnityEngine;

using UnityEngine.UI;

public class _bffScript : MonoBehaviour
{

    public _data data;

    private GameObject top;
    private GameObject pants;
    private GameObject skirt;
    private GameObject dress;
    private GameObject neck;
    private GameObject bag;
    private GameObject shoes;
    private GameObject gloves;
    private GameObject hair;
    private GameObject ear;
    private GameObject tiarra;

    private void Start()
    {
        top = transform.Find("top").gameObject;
        pants = transform.Find("pants").gameObject;
        skirt = transform.Find("skirt").gameObject;
        dress = transform.Find("dress").gameObject;
        neck = transform.Find("neck").gameObject;
        bag = transform.Find("bag").gameObject;
        shoes = transform.Find("shoes").gameObject;
        gloves = transform.Find("gloves").gameObject;
        hair = transform.Find("hair").gameObject;
        tiarra = transform.Find("tiarra").gameObject;
        ear = transform.Find("ear").gameObject;
    }

    private void Update()
    {
        if (data.top)
        {
            top.GetComponent<Image>().sprite = data.top;
            top.SetActive(true);
        }
        else
        {
            top.SetActive(false);
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

        if (data.skirt)
        {
            skirt.GetComponent<Image>().sprite = data.skirt;
            skirt.SetActive(true);
        }
        else
        {
            skirt.SetActive(false);
        }

        if (data.rochie)
        {
            dress.GetComponent<Image>().sprite = data.rochie;
            dress.SetActive(true);
        }
        else
        {
            dress.SetActive(false);
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

        if (data.bag)
        {
            bag.GetComponent<Image>().sprite = data.bag;
            bag.SetActive(true);
        }
        else
        {
            bag.SetActive(false);
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

        if (data.gloves)
        {
            gloves.GetComponent<Image>().sprite = data.gloves;
            gloves.SetActive(true);
        }
        else
        {
            gloves.SetActive(false);
        }

        if (data.parDressup)
        {
            hair.GetComponent<Image>().sprite = data.parDressup;
            hair.SetActive(true);
        }
        else
        {
            data.parDressup = data.parDefaultDressup;
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

        if (data.tiarra)
        {
            tiarra.GetComponent<Image>().sprite = data.tiarra;
            tiarra.SetActive(true);
        }
        else
        {
            tiarra.SetActive(false);
        }

    }
}
