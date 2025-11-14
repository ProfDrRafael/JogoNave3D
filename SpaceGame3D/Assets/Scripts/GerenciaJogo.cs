using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaJogo : MonoBehaviour
{
    public GameObject painelFracasso;
    public GameObject painelSucesso;
    public TextMeshProUGUI pontuacao;
    public TextMeshProUGUI contagem;
    public Jogador jogador;
    public float fatorDivisao;
    private Vector3 posicaoInicial;
    private bool jogoAcabado = false;

    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = jogador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (jogador != null && jogoAcabado == false)
        {
            string valorPontuacao = "";
            Vector3 diferenca;
            diferenca = jogador.transform.position - posicaoInicial;
            valorPontuacao = (diferenca.z / fatorDivisao).ToString("0");
            pontuacao.text = "Pontuação: " + valorPontuacao;
        }
    }

    public void GameOver()
    {

        painelFracasso.SetActive(true);
        StartCoroutine(Countdown());
        Invoke("ReloadLevel", 5);
    }

    IEnumerator Countdown()
    {
        int segundos = 5;
        while (segundos > 0)
        {
            contagem.text = segundos.ToString();
            yield return new WaitForSeconds(1f);
            segundos--;
        }
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameCompleted() {
        jogoAcabado = true;
        painelSucesso.SetActive(true);
    }

}
