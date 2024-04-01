using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    // Start is called before the first frame update
  [SerializeField] private int health= 100;

    private int Max_Health = 100;
    public Image bar;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
            {
           Damage(10);
        }
        bar.fillAmount = (float)health / Max_Health;
    }
    public void Damage(int amount ) 
    {

        if(amount < 0 )
        {
            throw new System.ArgumentOutOfRangeException("No danno oltre allo 0");
        }

        this.health -= amount;

        if (health <= 0)
        {
       Die();
        }



    }
    public void Heal(int amount)
    {

        if (health < 0)
        {
            throw new System.ArgumentOutOfRangeException("no cure negative?");
        }

        bool wouldbeOverMaxHealth = health + amount> Max_Health;
        
        if(wouldbeOverMaxHealth)
        {
            this.health = Max_Health;
        }
        else
        {
            this.health += Max_Health;
        }
    }
private void Die()
{
    if (gameObject.CompareTag("Enemy"))
    {
        Destroy(gameObject);
    }
}
}