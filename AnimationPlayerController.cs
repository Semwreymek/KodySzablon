using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayerController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {   
       
        //Przód
        if (Input.GetKey("w"))
        {
            animator.SetBool("isRuning", true);
            
        }
        if (!Input.GetKey("w"))
        {
            animator.SetBool("isRuning", false);
        }

        //Wsteczny
        if (Input.GetKey("s"))
        {
            animator.SetBool("isBacking", true);
        }
        if (!Input.GetKey("s"))
        {
            animator.SetBool("isBacking", false);
        }

        //Skok
        if (Input.GetKey("space"))
        {
            animator.SetBool("isJumping", true);
        }
        if (!Input.GetKey("space"))
        {
            animator.SetBool("isJumping", false);
        }
        //ser
       
    }
}
