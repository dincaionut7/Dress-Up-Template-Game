using System.Collections;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _backgroundSceneLoader : MonoBehaviour
{

    public string sceneName;

    public GameObject loadScreen;

    private Button sceneInitButton;

    

    //atribuirea unei valori catre referinta spre butonul de start
    //si definim comportament pentru un eventual event de tipul onClick
    void Start()
    {
       // sceneName = this.sceneName;
        sceneInitButton = GetComponent<Button>(); 
        sceneInitButton.onClick.AddListener(initLoading);
    }

    //funcite definita pentru a putea fi data ca argument mai sus ( in cazul listenerului,el nu putea primi corutine ca si argument)
    void initLoading()
    {
        StartCoroutine(SceneLoad());
    }


    /*Corutina implementata pentru a face tranzitia mai incet intre scene 
    * (in caz ca scena s'ar incarca prea repede , sa apara totusi loading screenul) */

    IEnumerator SceneLoad()
    {
        loadScreen.SetActive(true); // activam ecranul de incarcare corespunzataore folosind referinta catre aceasta
        AsyncOperation asyncOp = SceneManager.LoadSceneAsync(sceneName); // Este creata o instanta a unei operatii asincrone careia ii este atribuit tipul de "LoadSceneAsync"
        asyncOp.allowSceneActivation = false;

        while (!asyncOp.isDone)
        {
            
            if (asyncOp.progress >= 0.9f)
            {
                asyncOp.allowSceneActivation = true;
            }

            yield return new WaitForSecondsRealtime(2);
        }   
    }
}
