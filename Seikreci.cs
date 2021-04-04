using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seikreci : MonoBehaviour
{


    void Update()
    {
        transform.Rotate(new Vector3(10000f, 10000f, 0f) * Time.deltaTime);
        
    }
}
