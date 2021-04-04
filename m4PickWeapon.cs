using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m4PickWeapon : MonoBehaviour
{
    public GameObject weaponOnGround;
    public GameObject weaponInHands;

    private void Start()
    {
        weaponInHands.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {
        {
        if(other.gameObject.tag == ("Player"))
        {
            weaponOnGround.SetActive(false);
            weaponInHands.SetActive(true);
        }
    }
    }
}
