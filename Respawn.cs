    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public Transform spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        
        
        player.transform.position = spawnPoint.transform.position;
        
    }
}
