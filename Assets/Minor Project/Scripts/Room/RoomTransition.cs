using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomTransition : MonoBehaviour
{

    public GameObject transitionText;
    public GameObject loadingScreen;
    public GameObject getKeyFirst;
   

    IEnumerator LoadLevelAsync(string scene) {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(scene);
        while(!loadOperation.isDone)
            yield return null;
    }

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
                if (ItemsStats.isKeyEquipped == true)
                {
                    loadingScreen.SetActive(true);
                    StartCoroutine(LoadLevelAsync("Subway"));
                }
                else if(ItemsStats.isKeyEquipped == false)
                {
                    transitionText.SetActive(false);
                    getKeyFirst.SetActive(true);
                }
                
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        transitionText.SetActive(false);
        getKeyFirst.SetActive(false);
    }
}
