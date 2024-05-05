using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubwayTransition : MonoBehaviour
{
    public GameObject transitionText;
    public GameObject loadingScreen;
    public Transform insideMetro;

    /*IEnumerator LoadLevelAsync(int index)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(index);
        while (!loadOperation.isDone)
            yield return null;
    }*/
    private void OnTriggerEnter(Collider other)
    {
        transitionText.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (Input.GetKey(KeyCode.E))
            {
                other.gameObject.transform.position = insideMetro.position; 
                    //loadingScreen.SetActive(true);
                    //StartCoroutine(LoadLevelAsync(2));

                }

            }

        
    }
    private void OnTriggerExit(Collider other)
    {
        transitionText.SetActive(false);
       
    }
}
