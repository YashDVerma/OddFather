using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stove : MonoBehaviour
{
    // Start is called before the first frame update
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
