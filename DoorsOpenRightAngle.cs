using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsOpenRightAngle : MonoBehaviour
{
    
    public GameObject doorsR;
    public Rigidbody rb;
    public float openSpeed = 10f;
    bool isOpen = false;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("Player") && !isOpen) 
        {
            isOpen = true;
            rb.AddForce(new Vector3(1,0,openSpeed) *Time.deltaTime);
           
        }
        if(other.gameObject.tag == ("Destroy"))
        {
            Destroy(doorsR);
        }

    }
    
}
