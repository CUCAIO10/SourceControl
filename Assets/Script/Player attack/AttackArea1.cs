using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackArea1 : MonoBehaviour
{
    private int damage = 1;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);
        }
    }
}