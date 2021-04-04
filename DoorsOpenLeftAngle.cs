using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsOpenLeftAngle : MonoBehaviour
{
    
    public GameObject leftDoors;
    public Rigidbody rb;
    public  float openSpeed = 10f;
    private void Awake()
    {
        this.GetComponent<Rigidbody>().useGravity = false;
        rb = GetComponent<Rigidbody>();
    }


   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("Player"))
        {
          
            rb.AddForce(new Vector3(0, 0, -openSpeed)  * Time.deltaTime);
                        
        }
        if(other.gameObject.tag == ("Destroy"))
        {
            Destroy(leftDoors);
        }
              
    }

    
}
