using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource source;
    AudioClip ganaste;
    AudioClip chocaste;
    bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        // Busca en el componente el componente del tipo AudioSource y lo guarda en source
        // Lo que esta entre el mayor y menor es el tipo de componente
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        // El boolenao entra como true
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apenas toca, se torna el opuesto, en este caso false. Si vuelve a tocar, sera true por lo que se reprodcuira de vuelta

            if (isPlaying) // Si es true, el sonido se reproduce
            {
                source.Play();
            }

            else // Si es false, el sonido para
            {
                source.Stop();
            }

            isPlaying = !isPlaying;
        }
    }
}
