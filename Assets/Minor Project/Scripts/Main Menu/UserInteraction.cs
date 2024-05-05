using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInteraction : MonoBehaviour
{
    public void StartButton() {
        SceneManager.LoadScene("BedRoom");
    }

    public void ExitButton() {
        Application.Quit();
    }
   
}
