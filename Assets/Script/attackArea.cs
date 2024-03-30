using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackArea : MonoBehaviour
{
    private float damage = 1.5f; // Assicurati che il valore del danno sia di tipo float

    private void OnTriggerEnter2D(Collider2D collider)
    {
        HealthManager healthManager = collider.GetComponent<HealthManager>(); // Recupera il componente HealthManager

        if (healthManager != null)
        {
            healthManager.TakeDamage(damage); // Richiama il metodo TakeDamage() di HealthManager
        }
    }
}
