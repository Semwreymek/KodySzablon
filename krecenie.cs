using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class krecenie : MonoBehaviour
{
    

    
    
    void Update()
    {
        transform.Rotate(new Vector3(0f, 200f, 0f) * Time.deltaTime);
    }
}
