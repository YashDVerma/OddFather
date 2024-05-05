using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sink : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerEnter(Collider other)
    {
        obj.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        obj.SetActive(false);
    }
}
