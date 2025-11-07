using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public Rigidbody rb;
    public int forcaX, forcaZ;
    public GerenciaJogo gerenciaJogo;
    public AudioSource audioExplosao;

    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(0, 0, forcaZ);
        //Debug.Log("Start");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forcaZ);
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-forcaX * Time.fixedDeltaTime, 0, 0);
        }
        else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(forcaX * Time.fixedDeltaTime, 0, 0);
        }
        //Debug.Log("Update");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Jogador Colidiu com " + collision.collider.name);
        //if (collision.collider.name.Contains("Asteroide")) {
        if (collision.collider.CompareTag("Obstaculo"))
        {
            audioExplosao.Play();
            gerenciaJogo.GameOver();
        }
    }
}
