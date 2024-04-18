using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.XR;

public class Player : MonoBehaviour
{
    #region Propiedades
    public string NombreJugador;
    public Sprite ImagenJugador;
    public List<Card> Mazo = new List<Card>();
    public int[] PuntosAcumulados;

    public bool Turno;                                    
    public bool PasarTurno;                                 
    public bool Jugada;                                   
    public Text MazoContador;


    public GameObject ManoCartas;                               
    public GameObject[] CampoBatalla;
    public GameObject Clima;
    public GameObject[] Aumento;
    public GameObject Lider;
    
    #endregion 

    public void Cementerio()
    {
        Clima.GetComponent<Panels>().EliminarTodasLasCartas();

        foreach (GameObject item in CampoBatalla)
            item.GetComponent<Panels>().EliminarTodasLasCartas();

        foreach (GameObject item in Aumento)
            item.GetComponent<Panels>().EliminarTodasLasCartas();
    }
    private void Puntaje(int round)
    {
        int puntos = 0;
        foreach (GameObject item in CampoBatalla)
            puntos += item.GetComponent<Panels>().PuntosCampoDeBatalla();

        PuntosAcumulados[round] = puntos;
    }

    private void CubrirYJugar()
    {
        if (!Turno)                                                        
        {
            foreach (GameObject item in ManoCartas.GetComponent<Panels>().cards)
            {
                item.GetComponent<CardDisplay>().Cubierta.enabled = true;
                item.GetComponent<CardDisplay>().PuntajeAtaqueTexto.enabled = false;   
                item.GetComponent<Drag>().enabled = false;                
            }
            foreach(GameObject item in CampoBatalla)
                {
                    item.GetComponent<Drop>().enabled = false;
                }
        }
        else
        {
            if (!Jugada)
            {
                foreach (GameObject item in ManoCartas.GetComponent<Panels>().cards)
                {
                    item.GetComponent<CardDisplay>().Cubierta.enabled = false;
                    item.GetComponent<CardDisplay>().PuntajeAtaqueTexto.enabled = true;
                    item.GetComponent<Drag>().enabled = true;
                }
            }
                else
                {
                foreach (GameObject item in ManoCartas.GetComponent<Panels>().cards)
                {
                    item.GetComponent<CardDisplay>().Cubierta.enabled = false;      
                    item.GetComponent<Drag>().enabled = false;
                }
                }
                foreach (GameObject item in CampoBatalla)
                item.GetComponent<Drop>().enabled = true;
            }
        }

    private IEnumerator For(int maximo)                       
    {
        GameObject prefab = Resources.Load<GameObject>("Card");
        for (int i = 0; i < maximo; i++)
        {
            int random = Random.Range(1, Mazo.Count);
            GameObject aux = Instantiate(prefab, ManoCartas.transform);

            aux.GetComponent<CardDisplay>().card = Mazo[random];
            aux.name = Mazo[random].name;
            ManoCartas.GetComponent<Panels>().cards.Add(aux);
            Mazo.RemoveAt(random);

            yield return new WaitForSeconds(0.08f);
        }
    }

    public void RobarCartas(int numero = 0)
    {
        int numeroActual = ManoCartas.transform.childCount;

        if (numeroActual == 0)
            StartCoroutine(For(10));                      

        else if (numero != 0 && numeroActual < 10)               
            StartCoroutine(For(1));

        else if ((numeroActual != 0) && (numeroActual < 10))      
        {
            if (10 - numeroActual <= 2)
                StartCoroutine(For(10 - numeroActual));
            else
                StartCoroutine(For(2));
        }
    }

    void Start()
    {
        PuntosAcumulados = new int[3] { 0, 0, 0 };
    }

    public void Update()
    {
        Puntaje(GameManager.round);                 
        CubrirYJugar();                              
        MazoContador.text = Mazo.Count.ToString();
    }
}

