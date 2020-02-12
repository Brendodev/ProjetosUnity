using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGamerOver;
    private Aviao aviao;
    

    private void Start()
    {
        this.aviao = GameObject.FindObjectOfType<Aviao>();
    }
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        this.imagemGamerOver.SetActive(true);
       
    }
    public void ReiniciarJogo()
    {
        this.imagemGamerOver.SetActive(false);
        Time.timeScale = 1;
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
    }
    private void DestruirObstaculos ()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach( Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
