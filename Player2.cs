using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public CharacterController controller;

    [SerializeField] private float p2speed = 10f;

    [SerializeField] private float jumpHeight = 10f;

    [SerializeField] private float gravity = -9.81f;

    Vector3 direction;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        var movHori = Input.GetAxis("Horizontal") * p2speed * Time.deltaTime;
        var movVert = Input.GetAxis("Vertical") * p2speed * Time.deltaTime;

        direction = new Vector3(movHori, direction.y, movVert);

        Vector3 move = transform.right * movHori + transform.forward * movVert;
        controller.Move(move);

        direction.y += gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                direction.y = gravity * -jumpHeight;
            }
            if (direction.y < 1) direction.y = -2f;
        }

      
    }
}
