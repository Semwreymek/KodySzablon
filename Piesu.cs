using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piesu : MonoBehaviour
{
    int ruch = 10;
   

    void Update()
    {
        if(transform.position.x <= -8)
        {
            ruch = 3;
            
        }
        if(transform.position.x >= 8)
        {
            ruch = -3;
        }

        transform.Translate(ruch*Time.deltaTime,0,0);
        transform.Rotate(1000f * Time.deltaTime, 0f, 0f, Space.Self) ;
    }
}
