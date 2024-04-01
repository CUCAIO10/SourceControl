using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartoftheSkeleton : MonoBehaviour
{

    public GameObject Heart;

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se la collisione coinvolge il GameObject che deve morire
        if (collision.gameObject.CompareTag("Enemy")) // Supponiamo che il GameObject che muore abbia il tag "Enemy"
        {
            // Disattiva il GameObject che muore
            collision.gameObject.SetActive(false);

            // Attiva il GameObject che vuoi far comparire
            Heart.SetActive(true);
        }
    }


}