using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingM4 : MonoBehaviour
{

    public GameObject kurczakAmmo;

    public GameObject gunFront;

 
  

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            GameObject pocisk = Instantiate(kurczakAmmo);
            pocisk.transform.position = gunFront.transform.position + gunFront.transform.forward;
            pocisk.transform.forward = gunFront.transform.forward;
        }
    }
   
}
