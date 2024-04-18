using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class Drop : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    private void ActivarEfecto(CardDisplay item)
    {
        Player Jugador1 = GameObject.Find("GameManager").GetComponent<GameManager>().Jugador1;
        Player Jugador2 = GameObject.Find("GameManager").GetComponent<GameManager>().Jugador2;
        if (item.card.Especifico == Card.TipoDeCarta.clima)
        {
            item.card.climaCampo = Random.Range(0, 3);
            item.card.Efecto(Jugador1, Jugador2, 0, item.card.climaCampo, item.card.PuntajeAtaque);
        }
        else if (item.card.Especifico == Card.TipoDeCarta.aumento)
        {
            item.card.Efecto(GameManager.TurnoJugador);
        }
        else if (item.card.Especifico == Card.TipoDeCarta.despeje)
        {
            item.card.Efecto(GameManager.TurnoJugador, item.card.climaCampo, item.card.climaCampo);
        }
        else if (item.card.Nombre == "03" || item.card.Nombre == "06" || item.card.Nombre == "25" || item.card.Nombre == "28" || item.card.Nombre == "31")
        {
            item.card.Efecto(GameManager.TurnoJugador);
        }

        else if (item.card.Nombre == "09" || item.card.Nombre == "30")
        {
            item.card.Efecto(GameManager.TurnoJugador, item);
        }
        else if (item.card.Nombre == "08")
        {
            item.card.Efecto(GameManager.TurnoJugador);
        }
        else if (item.card.Nombre == "07")
        {
            item.card.Efecto(GameManager.TurnoJugador);
        }
        else if (item.card.Nombre == "29")
        {
            if(Jugador1.Turno)
                item.card.Efecto(Jugador2);
            else item.card.Efecto(Jugador1);
        }
        else if (item.card.Nombre == "04" || item.card.Nombre == "26")
        {
            item.card.Efecto(GameManager.TurnoJugador);
        }
        else if (item.card.Nombre == "02" || item.card.Nombre == "05" || item.card.Nombre == "24" || item.card.Nombre == "27")
        {
            item.card.Efecto(GameManager.TurnoJugador);
        }
        else if (item.card.Nombre == "01" || item.card.Nombre == "23")
        {
            item.card.Efecto(GameManager.TurnoJugador);
        }
    }
    private bool PosicionCarta(Drop item, GameObject item2)
    {
        foreach (Card.CampoDeBatalla i in item.GetComponent<Panels>().Posicion)
        {
            if (i == item2.GetComponent<CardDisplay>().EspecificarMuestra)
                return true;
        }
        return false;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnPointerExit(PointerEventData eventData)
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        Drag item = eventData.pointerDrag.GetComponent<Drag>();

        if (item != null && this.GetComponent<Panels>().itemsCounter < this.GetComponent<Panels>().maxItems && PosicionCarta(this, eventData.pointerDrag))             
        {
            item.parent = this.transform; 
            this.GetComponent<Panels>().cards.Add(eventData.pointerDrag);
            GameManager.TurnoJugador.ManoCartas.GetComponent<Panels>().cards.Remove(eventData.pointerDrag);
            GameManager.TurnoJugador.Jugada = true;

            if (eventData.pointerDrag.GetComponent<CardDisplay>().card.Efecto != null)
            {
                ActivarEfecto(eventData.pointerDrag.GetComponent<CardDisplay>());
            }
        }                                               
    }
}
