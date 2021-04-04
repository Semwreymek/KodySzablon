using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    

    [SerializeField]
    private GameObject  second;
    void Start()
    {

        second.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            second.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            second.SetActive(false);
        }
        
    }
   
    
}
