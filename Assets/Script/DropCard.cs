using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR;

public class DropCard : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    private string TipoDeCartaTexto(Card.TipoDeCarta tipo)
    {
        switch (tipo)
        {
             case Card.TipoDeCarta.lider:
                return "Leader";
            case Card.TipoDeCarta.heroe:
                return "Hero";
            case Card.TipoDeCarta.plata:
                return "Silver";
            case Card.TipoDeCarta.senuelo:
                return "Bait";
            case Card.TipoDeCarta.despeje:
                return "Clear";
            case Card.TipoDeCarta.clima:
                return "Climate";
            case Card.TipoDeCarta.aumento:
                return "Increase";
           
        }
        return "";
    }
    private string CampoDeBatallaTexto(Card.CampoDeBatalla posicion)
    {
        switch (posicion)
        {
            case Card.CampoDeBatalla.M:
                return "Melee";
            case Card.CampoDeBatalla.R:
                return "Range";
            case Card.CampoDeBatalla.S:
                return "Siege";
            case Card.CampoDeBatalla.MR:
                return "Melee-Range";
            case Card.CampoDeBatalla.MS:
                return "Melee-Siege";
             case Card.CampoDeBatalla.RS:
                return "Range-Siege";   
            case Card.CampoDeBatalla.MRS:
                return "Melee-Range-Siege";
            
        }
        return "";
    }
    public void OnPointerEnter(PointerEventData evenData)
    {

        if (this != null && !this.GetComponent<CardDisplay>().Cubierta.enabled)
        {
            GameObject.Find("Panel_Card").transform.GetChild(0).GetComponent<Image>().sprite = this.GetComponent<CardDisplay>().ImagenCarta.sprite;
            GameObject.Find("Panel_Card").transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().sprite = this.GetComponent<CardDisplay>().Marco.sprite;
            GameObject.Find("Panel_Card").transform.GetChild(3).GetComponent<Text>().text = this.GetComponent<CardDisplay>().PuntajeAtaqueTexto.text;   
            GameObject.Find("Panel_Card").transform.GetChild(5).GetComponent<Text>().text = TipoDeCartaTexto(this.GetComponent<CardDisplay>().EspecificoMuestra);
            GameObject.Find("Panel_Card").transform.GetChild(7).GetComponent<Text>().text = CampoDeBatallaTexto(this.GetComponent<CardDisplay>().EspecificarMuestra);
        }

    }
    public void OnPointerExit(PointerEventData evenData)
    {
        if (this != null)
        {
            GameObject.Find("Panel_Card").transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Panel");
            GameObject.Find("Panel_Card").transform.GetChild(3).GetComponent<Text>().text = "";
            GameObject.Find("Panel_Card").transform.GetChild(5).GetComponent<Text>().text = "";
            GameObject.Find("Panel_Card").transform.GetChild(7).GetComponent<Text>().text = "";
        }
    }
    public void OnDrop(PointerEventData evenData)
    {
    
    }
}
