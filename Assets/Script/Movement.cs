using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    
    public CharacterController2D Controller;
    public float runSpeed = 35f;
    
     // public KeyCode attackKey = KeyCode.Space;

    public Animator animator;

    float horizonalmove = 0f;





   /* private GameObject attackArea = default;
    private bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 0f; */
    public void Start()
    {
      // attackArea = transform.GetChild(0).gameObject;

    }

    public void Update()
    {
     horizonalmove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs( horizonalmove));
        
   /* if(Input.GetKeyDown(attackKey))
    {

        Attack();
    }
    
    
        if(attacking)
        {
            timer += Time.deltaTime;

        if(timer >= timeToAttack)
        {

            timer = 0;
            attacking = false;
            attackArea.SetActive(attacking);

        }


        } */
    }
    private void FixedUpdate()
    {
        //movimento
        Controller.Move(horizonalmove * Time.fixedDeltaTime, false,false);
        
    }

    /* private void Attack()
    {

        attacking = true;
        attackArea.SetActive(attacking);


    }

    */
}