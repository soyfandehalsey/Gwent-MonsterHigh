using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Panels : MonoBehaviour 
{
    public List<GameObject> cards = new List<GameObject>();
    public List<Card.CampoDeBatalla> Posicion = new List<Card.CampoDeBatalla>();     
    public int maxItems;                                                           
    public int itemsCounter;                                                       

    public int CounterUnity()
    {
        int counter = 0;
        foreach(GameObject item in cards)
            if(item.GetComponent<CardDisplay>().card.EsCartaUnidad)
                counter++;
        return counter;
    }
    public void EliminarTodasLasCartas()                                                        
    {
        for (int i = 0; i < cards.Count; i++)
        {
            GameObject.Destroy(cards[i]);
            cards.RemoveAt(i);
        }
    }
    private void EliminarCarta()                                                          
    {
        if(cards != null && cards.Count > 0) 
        { 
            for (int i = 0; i < cards.Count; i++) 
            { 
                if (cards[i] == null) 
                { 
                    cards.RemoveAt(i); 
                } 
                else if (cards[i].GetComponent<CardDisplay>().card.EsCartaUnidad && int.Parse(cards[i].GetComponent<CardDisplay>().PuntajeAtaqueTexto.text) <= 0)
                {
                    GameObject.Destroy(cards[i]);
                    cards.RemoveAt(i);
                }
            } 
        }
    }
    public int PuntosCampoDeBatalla()
    {
        int puntosCampoDeBatalla = 0;

        if (cards != null && cards.Count > 0)
        {
            foreach (GameObject item in cards)
                if(item != null && item.GetComponent<CardDisplay>().card.EsCartaUnidad)
                    puntosCampoDeBatalla += int.Parse(item.GetComponent<CardDisplay>().PuntajeAtaqueTexto.text);
        }

        return puntosCampoDeBatalla;
    }
    private void UnDragging()
    {
        if (cards != null && cards.Count > 0 && GameManager.TurnoJugador.ManoCartas.name != this.name)
            foreach (GameObject item in cards)
                item.GetComponent<Drag>().enabled = false;
    }
    private void Start()
    {

    }
    private void Update()
    {
        EliminarCarta();                                                                                                      
        itemsCounter = cards.Count;                                                                              
        UnDragging();                                                               
    }
}

