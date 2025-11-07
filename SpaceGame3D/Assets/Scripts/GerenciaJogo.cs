using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaJogo : MonoBehaviour
{
    public GameObject painel;
    public TextMeshProUGUI pontuacao;
    public Jogador jogador;
    public float fatorDivisao;
    private Vector3 posicaoInicial;

    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = jogador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        string valorPontuacao = "";
        Vector3 diferenca;
        diferenca = jogador.transform.position - posicaoInicial;
        valorPontuacao = (diferenca.z/fatorDivisao).ToString("0");
        pontuacao.text = "Pontuação: " + valorPontuacao;
    }

    public void GameOver()
    {
        painel.SetActive(true);
        Invoke("RecarregarFase", 5);
    }

    public void RecarregarFase()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
