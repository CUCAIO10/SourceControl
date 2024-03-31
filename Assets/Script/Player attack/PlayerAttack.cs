using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    private GameObject attackArea = default;

    private bool attacking = false;

    private float TimeToAttack = 1.5f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            Attack();
            animator.SetBool("attacking",false);
        }
        if(attacking)
        {
             timer += Time.deltaTime;

            if(timer >= TimeToAttack) 
            {
                timer = 0;
                attacking= false;
                attackArea.SetActive(attacking);
            }

        }
        if(attacking==false)
        {
            animator.SetBool("attacking", false);

        }
        else
        {
            animator.SetBool("attacking", true);
        }

    }
    private void Attack()
    {
        
        attacking = true;

        attackArea.SetActive(attacking);
    }
}
