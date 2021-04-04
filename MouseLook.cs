using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private float mouseSens = 100f;

    public Transform cialoGracza;

    float obrotX = 0f;
    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        cialoGracza.Rotate(new Vector3(0, 1, 0)*mouseX);

        obrotX -= mouseY;

        obrotX = Mathf.Clamp(obrotX, -90f, 90f); 
        
       
        transform.localRotation = Quaternion.Euler(obrotX, 0f, 0f);

    }
}

