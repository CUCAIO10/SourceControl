using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D Controller;
    public float runSpeed = 35f;
    bool Jump = false;
    public Animator animator;

    float horizonalmove = 0f;
    public void Start()
    {
        
    }

    public void Update()
    {
     horizonalmove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs( horizonalmove));

        if(Input.GetButtonDown("Jump"))
        {
            Jump = true;
        }
        
    }
    private void FixedUpdate()
    {
        //movimento
        Controller.Move(horizonalmove * Time.fixedDeltaTime, false,false);
        
    }

}