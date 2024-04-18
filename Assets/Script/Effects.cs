using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public static class Efectos
{
    public static void AumentoFilaPropia(params object[] item)
    {
        if (item[0] is Player player)
        {
            for (int j = 0; j < 3; j++)
                if (player.Aumento[j].GetComponent<Panels>().cards.Count != 0)
                    for (int i = 0; i < player.CampoBatalla[j].GetComponent<Panels>().cards.Count; i++)
                        if (player.CampoBatalla[j].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().card.EsCartaUnidad && !player.CampoBatalla[j].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().card.EsCartaHeroe && !player.CampoBatalla[j].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().CartaAumentoActiva)
                            player.CampoBatalla[j].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().Conteo(player.Aumento[j].GetComponent<Panels>().cards[0].GetComponent<CardDisplay>().card.PuntajeAtaque);
        }
    }   
    public static void ActivarClima(params object[] item)
    {
        if (item[0] is Player Jugador1 && item[1] is Player Jugador2 && item[2] is int pos && item[3] is int conteo)
        {
            for (int i = 0; i < Jugador1.CampoBatalla[pos].GetComponent<Panels>().cards.Count; i++)
                if (Jugador1.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().card.EsCartaUnidad && !Jugador1.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().card.EsCartaHeroe && !Jugador1.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().CartaClimaActiva)
                { Jugador1.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().Conteo(conteo); Jugador1.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().CartaClimaActiva = true; }

            for (int i = 0; i < Jugador2.CampoBatalla[pos].GetComponent<Panels>().cards.Count; i++)
                if (Jugador2.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().card.EsCartaUnidad && !Jugador2.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().card.EsCartaHeroe && !Jugador2.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().CartaClimaActiva)
                { Jugador2.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().Conteo(conteo); Jugador2.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().CartaClimaActiva = true; }
        }
    }   
    public static void EliminarCartaMayorPoderCampo(params object[] item)
    {
        if (item[0] is Player player)
        {
            GameObject panelMax = null; int index = 0;
            foreach (GameObject row in player.CampoBatalla)
            {
                foreach (GameObject rowCard in row.GetComponent<Panels>().cards)
                {
                    if (panelMax == null && rowCard.GetComponent<CardDisplay>().card.EsCartaUnidad)
                    {
                        panelMax = row;
                        index = row.GetComponent<Panels>().cards.IndexOf(rowCard);
                    }

                    else if (int.Parse(rowCard.GetComponent<CardDisplay>().PuntajeAtaqueTexto.text) > int.Parse(panelMax.GetComponent<Panels>().cards[index].GetComponent<CardDisplay>().PuntajeAtaqueTexto.text))
                    {
                        panelMax = row;
                        index = row.GetComponent<Panels>().cards.IndexOf(rowCard);
                    }
                }
            }
            if (panelMax != null)
                GameObject.Destroy(panelMax.GetComponent<Panels>().cards[index]);
        }
    }
    public static void EliminarCartaMenorPoderOponente(params object[] item)
    {
        if (item[0] is Player player)
        {
            GameObject panelMin = null; int index = 0;
            foreach (GameObject row in player.CampoBatalla)
            {
                foreach (GameObject rowCard in row.GetComponent<Panels>().cards)
                {
                    if (panelMin == null && rowCard.GetComponent<CardDisplay>().card.EsCartaUnidad)
                    {
                        panelMin = row;
                        index = row.GetComponent<Panels>().cards.IndexOf(rowCard);
                    }

                    else if (int.Parse(rowCard.GetComponent<CardDisplay>().PuntajeAtaqueTexto.text) < int.Parse(panelMin.GetComponent<Panels>().cards[index].GetComponent<CardDisplay>().PuntajeAtaqueTexto.text))
                    {
                        panelMin = row;
                        index = row.GetComponent<Panels>().cards.IndexOf(rowCard);
                    }
                }
            }
            if (panelMin != null)
                GameObject.Destroy(panelMin.GetComponent<Panels>().cards[index]);
        }
    }
    public static void RobarCarta(params object[] item)
    {
        if (item[0] is Player player)
            player.RobarCartas(1);
    }

    public static void Robar2Cartas(params object[] item)
    {
        if (item[0] is Player player)
            player.RobarCartas(2);
    }

    public static void MultiplicarPoderSegunCantidadDeCopias(params object[] item)
    {
        if (item[0] is Player player && item[1] is CardDisplay card)
        {
            int contador = 0;
            foreach (GameObject row in player.CampoBatalla)
            {
                foreach (GameObject cardRow in row.GetComponent<Panels>().cards)
                    if (card.card.name == cardRow.name)
                        contador++;
            }
            if (contador != 0)
                card.ActualizarPoder(contador * int.Parse(card.PuntajeAtaqueTexto.text));
        }
    }
    public static void LimpiarFila(params object[] item)
    {
        if (item[0] is Player player)
        {
            GameObject minRow = player.CampoBatalla[0];
            foreach (GameObject row in player.CampoBatalla)
                if (((row.GetComponent<Panels>().CounterUnity() > 0) && (row.GetComponent<Panels>().CounterUnity() < minRow.GetComponent<Panels>().CounterUnity())))
                    minRow = row;
            minRow.GetComponent<Panels>().EliminarTodasLasCartas();
        }
    }
    public static void PromediarEIgualar(params object[] item) 
    {
        if (item[0] is Player player)
        {
            int counterUnity = 0;
            int auxCounterUnity = 0;
            foreach (GameObject item2 in player.CampoBatalla)
            { auxCounterUnity += item2.GetComponent<Panels>().PuntosCampoDeBatalla(); counterUnity += item2.GetComponent<Panels>().CounterUnity(); }

            foreach (GameObject item2 in player.CampoBatalla)
                for (int i = 0; i < item2.GetComponent<Panels>().cards.Count; i++)
                    item2.GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().ActualizarPoder(auxCounterUnity/counterUnity);
        }
    }
    public static void ManoDevolver(params object[] item)
    {

    }

    public static void DespejarClima(params object[] item)
    {
        if (item[0] is Player player && item[1] is int pos)
        {
            if (player.Clima.GetComponent<Panels>().cards.Count != 0)
            {
               int conteo = player.Clima.GetComponent<Panels>().cards[0].GetComponent<CardDisplay>().card.PuntajeAtaque;
                for (int i = 0; i < player.CampoBatalla[pos].GetComponent<Panels>().cards.Count; i++)
                    if (player.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().card.EsCartaUnidad && !player.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().card.EsCartaHeroe)
                        player.CampoBatalla[pos].GetComponent<Panels>().cards[i].GetComponent<CardDisplay>().Conteo(conteo); 
            GameObject.Destroy(player.Clima.GetComponent<Panels>().cards[0]);
            }
        }
    } 

    public static void Ganar(params object[] item)
    {
        if (item[0] is Player player)
            player.RobarCartas(3);
    }
}
