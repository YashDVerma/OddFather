using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDrop : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform finalPlatform;
    public Transform player;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            PlatShift.count++;
            if(PlatShift.count <=3)
                finalPlatform.Translate(Vector3.right * 9.166f * PlatShift.count);
            player.position = spawnPoint.position;
        }

    }

    

}
