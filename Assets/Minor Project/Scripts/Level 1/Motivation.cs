using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motivation : MonoBehaviour
{
    public GameObject[] diags;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            if (PlatShift.count == 0)
                diags[0].SetActive(true);
            else if (PlatShift.count == 1)
                diags[1].SetActive(true);
            else if (PlatShift.count == 2)
                diags[2].SetActive(true);
            else if (PlatShift.count == 3)
                diags[3].SetActive(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        for(int i = 0; i <= 3; i++)
        {
            diags[i].SetActive(false);
        }
    }
}
