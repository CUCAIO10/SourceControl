using UnityEngine;

public class RepeatAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public float repeatInterval = 40f; // Intervallo di ripetizione in secondi
    private float timer = 0f;

    void Start()
    {
        // Controlla se l'AudioSource è stato assegnato
        if (audioSource == null)
        {
            Debug.LogError("AudioSource non assegnato al RepeatAudio script.");
            enabled = false; // Disabilita lo script se l'AudioSource non è stato assegnato correttamente
        }
    }

    void Update()
    {
        // Aggiorna il timer
        timer += Time.deltaTime;

        // Controlla se è passato l'intervallo di ripetizione
        if (timer >= repeatInterval)
        {
            // Riproduci l'AudioSource
            audioSource.Play();
            
            // Resetta il timer
            timer = 0f;
        }
    }
}
