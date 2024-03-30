using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vita : MonoBehaviour
{
    public Image HealthBar;
    public int health;
    public int maxHealth=100;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        health -= amount;
        HealthBar.fillAmount= amount;   
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}