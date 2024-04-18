using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;
using static Card;

public class CardDisplay : MonoBehaviour
{
    public Card card;                          
    public Text PuntajeAtaqueTexto;                                 
    public TipoDeCarta EspecificoMuestra;
    public CampoDeBatalla EspecificarMuestra;
    public bool CartaClimaActiva;
    public bool CartaAumentoActiva;
    public Image ImagenCarta;
    public Image Marco;                
    public Image Cubierta;

    public void Conteo(int conteo) => PuntajeAtaqueTexto.text = (int.Parse(PuntajeAtaqueTexto.text) + conteo).ToString();
    public void ActualizarPoder(int conteo) => PuntajeAtaqueTexto.text = conteo.ToString();

    void Start()
    {
        EspecificoMuestra = card.Especifico;             
        EspecificarMuestra = card.Especificar;
        PuntajeAtaqueTexto.text = card.PuntajeAtaque.ToString();
        ImagenCarta.sprite = card.ImagenCarta;
        Marco.sprite = card.Marco;
    }
    void Update()
    {
        if (card != null) 
        {
            PuntajeAtaqueTexto.text = PuntajeAtaqueTexto.text;
        }
    }
}
