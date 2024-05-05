using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionSubWay : MonoBehaviour
{
    public GameObject loadingScreen;

    public void LoadScene() {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene("Level 1");
    }
}
