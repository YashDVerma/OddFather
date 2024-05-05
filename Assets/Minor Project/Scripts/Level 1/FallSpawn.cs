using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSpawn : MonoBehaviour
{
    public Transform spawnPoint, dropLimit, player;


    private void Start()
    {
        player.position = spawnPoint.position; 
    }
    // Update is called once per frame
    void Update()
    {
        if (player.position.y < dropLimit.position.y)
        {
            player.position = spawnPoint.position;
           

        }
    }
}
