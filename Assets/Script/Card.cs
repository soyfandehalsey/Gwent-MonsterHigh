using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string Nombre;                                                            
    public int PuntajeAtaque;
    public enum TipoDeCarta { lider, heroe, plata, senuelo, clima, despeje, aumento};
    public enum CampoDeBatalla { M, R, S, MR, MS, RS, MRS, I, C, L};
    public TipoDeCarta Especifico;                                                          
    public CampoDeBatalla Especificar;
    public int climaCampo;
    public bool EsCartaUnidad;                                                          
    public bool EsCartaHeroe;
    public delegate void EfectoCarta(params object[] item);
    public EfectoCarta Efecto;
    public Sprite ImagenCarta;
    public Sprite Marco;

    public Card(string nombre, int puntajeAtaque, bool esCartaUnidad, bool esCartaHeroe, TipoDeCarta especifico, Sprite imagenCarta, Sprite marco)
    {
        this.Nombre = nombre;
        this.PuntajeAtaque = puntajeAtaque;
        this.EsCartaUnidad = esCartaUnidad;
        this.EsCartaHeroe = esCartaHeroe;
        this.Especifico = especifico;
        this.ImagenCarta = imagenCarta;
        this.Marco = marco;
    }

      public Card(string nombre, int puntajeAtaque, bool esCartaUnidad, bool esCartaHeroe, TipoDeCarta especifico, CampoDeBatalla especificar, EfectoCarta efecto, Sprite imagenCarta, Sprite marco)
    {
        this.Nombre = nombre;
        this.PuntajeAtaque = puntajeAtaque;
        this.EsCartaUnidad = esCartaUnidad;
        this.EsCartaHeroe = esCartaHeroe;
        this.Especifico = especifico;
        this.Especificar = especificar;
        this.Efecto = efecto;
        this.ImagenCarta = imagenCarta;
        this.Marco = marco;
    }

    public Card(string nombre, int puntajeAtaque, bool esCartaUnidad, bool esCartaHeroe, TipoDeCarta especifico, EfectoCarta efecto, Sprite imagenCarta, Sprite marco)
    {
        this.Nombre = nombre;
        this.PuntajeAtaque = puntajeAtaque;
        this.EsCartaUnidad = esCartaUnidad;
        this.EsCartaHeroe = esCartaHeroe;
        this.Especifico = especifico;
        this.Efecto = efecto;
        this.ImagenCarta = imagenCarta;
        this.Marco = marco;
    }

    public Card(string nombre, int puntajeAtaque, bool esCartaUnidad, bool esCartaHeroe, TipoDeCarta especifico, CampoDeBatalla especificar, Sprite imagenCarta, Sprite marco)
    {
        this.Nombre = nombre;
        this.PuntajeAtaque = puntajeAtaque;
        this.EsCartaUnidad = esCartaUnidad;
        this.EsCartaHeroe = esCartaHeroe;
        this.Especifico = especifico;
        this.Especificar = especificar;
        this.ImagenCarta = imagenCarta;
        this.Marco = marco;
    }
    
}
