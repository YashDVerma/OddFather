using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalwin : MonoBehaviour
{
    public GameObject dg;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            dg.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        dg.SetActive(false);
    }
}
