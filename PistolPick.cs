using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPick : MonoBehaviour
{
    public GameObject pistolOnground;
    public GameObject pistolInHand;
    void Start()
    {
        pistolInHand.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            pistolInHand.SetActive(false);
            pistolOnground.SetActive(false);
        }
        if (other.gameObject.tag == ("Player"))
        {
            pistolInHand.SetActive(true);
            pistolOnground.SetActive(false);
        }

       
        
    }
   
}

