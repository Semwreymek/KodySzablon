using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public GameObject enemy;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == ("ground"))
        {

            Destroy(enemy);
        }
    }
        
}



