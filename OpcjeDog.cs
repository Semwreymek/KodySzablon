using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpcjeDog : MonoBehaviour
{
    float predkosc = 1f;
   
    void Update()
    {
        if(transform.position.y <= 0.50)
        {
            predkosc = 1f;
        }

        if(transform.position.y >= 2.50)
        {
            predkosc = -1f;
        }
        transform.Translate(0f, predkosc * Time.deltaTime, 0f);

    }
}
