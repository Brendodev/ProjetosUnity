using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    private int pontos;
    [SerializeField]
    private Text textoPontuacao;

    public void AdicionarPontos()
    {
        this.pontos++;
        Debug.Log(this.pontos);
        this.textoPontuacao.text = this.pontos.ToString();
    }

}
