using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciaAudio : MonoBehaviour
{
    public AudioClip[] vetorMusicas;
    public AudioSource audioMusicas;
    public AudioSource audioVitoria;
   
    // Start is called before the first frame update
    void Start()
    {
        audioMusicas.clip = vetorMusicas[Random.Range(0, 2)];
        audioMusicas.Play();
    }

    void anunciarVitoria()
    {
        audioVitoria.Play();
    }

}
