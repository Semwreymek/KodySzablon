using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public Transform baseTwo;
    public CharacterController controller;

    [SerializeField]
    private float pSpeed = 8f;

    [SerializeField]
    private float grawitacja = -10.8f;

    [SerializeField]
    private float jumpHeight = 0.5f;

    
    private float basicJumpheight = 0.5f;


    private float pBasicSpeed = 8f;

    private Vector3 kierunek;

   
 
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
       
    }

    void Update()
    {
        
        var ruchHorizontal = Input.GetAxis("Horizontal") * pSpeed * Time.deltaTime;
        var ruchVertical = Input.GetAxis("Vertical") * pSpeed * Time.deltaTime;

        kierunek = new Vector3(ruchHorizontal, kierunek.y, ruchVertical);
        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                kierunek.y += -jumpHeight * grawitacja;
                Sfx.PlaySound("Mario");

            }
            if (kierunek.y < 0)  //Sapobiega stackowaniu się grawitacji przez resetowanie jej do 0 przy ujemnej wartości
            {
                kierunek.y = -1f;
            }   

        }

        Vector3 ruch = transform.right * ruchHorizontal + transform.forward * ruchVertical;
        controller.Move(ruch);

        

        kierunek.y += grawitacja * Time.deltaTime;  //Spaedk w dół +=Grawitacja, stackuje sie ciągle w dół 
        controller.Move(kierunek * Time.deltaTime);

        /* var input = Input.inputString;
             switch (input)
         {
             case "left shift":
                 pSpeed = 10f;
                 break;

             case "left ctrl":
                 controller.height = 1f;
                 pSpeed = 3f;
                 break;                  nie działa  ;/
         }
        */
        
         if (Input.GetKeyDown(KeyCode.LeftControl))     
         {
             controller.height = 1f;
            pSpeed = 3f;
        }
       if (Input.GetKeyUp(KeyCode.LeftControl))     
         {
             controller.height = 3f;
            pSpeed = pBasicSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
  
    }


    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        switch (hit.gameObject.tag)
        {                                   
            case "jumpB":
                jumpHeight = 0.8f;
                break;
            case "jumpD":
                jumpHeight = 0.5f;
                break;
            case "speedB":
                pSpeed = 15f;
                break;
            case "speedD":
                pSpeed = 4f;
                break;
            case "normalSpeed":
                pSpeed = pBasicSpeed;
                break;
            case "normalJump":
                jumpHeight = basicJumpheight;
                break;
            case "allNormal":
                jumpHeight = basicJumpheight;
                pSpeed = pBasicSpeed;
                break;
            case "allDecreased":
                jumpHeight = 0.3f;
                pSpeed = 4f;
                break;
            case "allBoost":
                pSpeed = 20f;
                jumpHeight = 1f;
                break;


            default:
                jumpHeight = basicJumpheight;
                pSpeed = pBasicSpeed;
                break;
        }
        

    }


    private void OnTriggerStay(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "jumpB":
                jumpHeight = 1f;
                break;
            case "jumpD":
                jumpHeight = 0.2f;
                break;
            case "speedB":
                pSpeed = 20f;
                break;
            case "speedD":
                pSpeed = 4f;
                break;
           
           
            default:
                jumpHeight = basicJumpheight;
                pSpeed = pBasicSpeed;
                break;
        }

        if (other.gameObject.tag.Equals("tepek"))
        {
            player.transform.position = baseTwo.transform.position;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Points"))
        {
            Sfx.PlaySound("Coinsy");
            Destroy(other.gameObject);
            Score.scoreValue += 1;
        }
    }


}

