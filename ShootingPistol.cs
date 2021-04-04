using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPistol : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunFront;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject pocisk = Instantiate(bullet);

            pocisk.transform.position = gunFront.transform.position;
;
            pocisk.transform.forward = gunFront.transform.forward;


        }
    }
}
