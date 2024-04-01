using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAttack : MonoBehaviour
{
    public Animator animator;
    private GameObject attackArea2 = default;

    private bool attacking = false;

    private float TimeToAttack = 1.5f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        attackArea2 = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
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
                attackArea2.SetActive(attacking);
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

        attackArea2.SetActive(attacking);
    }
}
