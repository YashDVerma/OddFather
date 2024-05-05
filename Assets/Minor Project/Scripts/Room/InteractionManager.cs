using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public GameObject pickupScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Key")) {
            pickupScreen.SetActive(true);
            if (Input.GetKey(KeyCode.E)) {
                Destroy(other.gameObject);
                ItemsStats.isKeyEquipped = true;
                pickupScreen.SetActive(false);

            }

                
        }
    }
    private void OnTriggerExit(Collider other)
    {
        pickupScreen.SetActive(false);
    }
}
