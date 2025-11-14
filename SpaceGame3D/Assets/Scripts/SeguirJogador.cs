using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    public Jogador jogador;
    public Vector3 distanciaJogador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jogador != null)
        {
            this.transform.position = jogador.transform.position + distanciaJogador;
        }
    }
}
