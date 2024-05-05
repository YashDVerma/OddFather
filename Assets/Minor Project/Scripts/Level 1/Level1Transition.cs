using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Transition : MonoBehaviour
{
    public GameObject loadScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            loadScreen.SetActive(true);
            SceneManager.LoadScene("Main Menu");
    }
}
