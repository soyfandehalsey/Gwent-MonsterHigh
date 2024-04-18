using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public List<Card> MazoMonsterHighJugador = new List<Card>();
    public List<Card> MazoMonsterHighOponente = new List<Card>();
    public void CreateCard()                         
    {
        MazoMonsterHighJugador.Add(new Card("01", 0, false, false, Card.TipoDeCarta.lider, Card.CampoDeBatalla.L, Efectos.Ganar, Resources.Load<Sprite>("DGCCFL"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighJugador.Add(new Card("02", 5, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.MRS, Efectos.LimpiarFila, Resources.Load<Sprite>("Draculaura"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighJugador.Add(new Card("03", 7, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.RS, Efectos.RobarCarta, Resources.Load<Sprite>("Cleo"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighJugador.Add(new Card("04", 6, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.MR, Efectos.PromediarEIgualar, Resources.Load<Sprite>("Clawdeen"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighJugador.Add(new Card("05", 8, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.S, Efectos.LimpiarFila, Resources.Load<Sprite>("Frankie"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighJugador.Add(new Card("06", 6, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.M, Efectos.RobarCarta, Resources.Load<Sprite>("Ghoulia"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighJugador.Add(new Card("07", 5, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.MS, Efectos.EliminarCartaMayorPoderCampo, Resources.Load<Sprite>("Apple"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("07", 5, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.MS, Efectos.EliminarCartaMayorPoderCampo, Resources.Load<Sprite>("Apple"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("07", 5, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.MS, Efectos.EliminarCartaMayorPoderCampo, Resources.Load<Sprite>("Apple"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("08", 4, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.RS, Efectos.Robar2Cartas, Resources.Load<Sprite>("Briar"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("08", 4, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.RS, Efectos.Robar2Cartas, Resources.Load<Sprite>("Briar"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("08", 4, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.RS, Efectos.Robar2Cartas, Resources.Load<Sprite>("Briar"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("09", 5, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.R, Efectos.MultiplicarPoderSegunCantidadDeCopias, Resources.Load<Sprite>("Cherise"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("09", 5, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.R, Efectos.MultiplicarPoderSegunCantidadDeCopias, Resources.Load<Sprite>("Cherise"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("09", 5, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.R, Efectos.MultiplicarPoderSegunCantidadDeCopias, Resources.Load<Sprite>("Cherise"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("10", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Clawd"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("11", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Gillington"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("12", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Jackson"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("13", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Heat"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("14", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Holt"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("15", 0, false, false, Card.TipoDeCarta.despeje, Efectos.DespejarClima, Resources.Load<Sprite>("Spectra"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("16", 0, false, false, Card.TipoDeCarta.despeje, Efectos.DespejarClima, Resources.Load<Sprite>("Lagoona"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighJugador.Add(new Card("17", -1, false, false, Card.TipoDeCarta.clima, Card.CampoDeBatalla.C, Efectos.ActivarClima, Resources.Load<Sprite>("Jinafire"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighJugador.Add(new Card("18", -1, false, false, Card.TipoDeCarta.clima, Card.CampoDeBatalla.C, Efectos.ActivarClima, Resources.Load<Sprite>("Rochelle"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighJugador.Add(new Card("19", -1, false, false, Card.TipoDeCarta.clima, Card.CampoDeBatalla.C, Efectos.ActivarClima, Resources.Load<Sprite>("Abbie"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighJugador.Add(new Card("20", 3, false, false, Card.TipoDeCarta.aumento, Card.CampoDeBatalla.I, Efectos.AumentoFilaPropia, Resources.Load<Sprite>("Skelita"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighJugador.Add(new Card("21", 3, false, false, Card.TipoDeCarta.aumento, Card.CampoDeBatalla.I, Efectos.AumentoFilaPropia, Resources.Load<Sprite>("Luna"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighJugador.Add(new Card("22", 3, false, false, Card.TipoDeCarta.aumento, Card.CampoDeBatalla.I, Efectos.AumentoFilaPropia, Resources.Load<Sprite>("Nefera"), Resources.Load<Sprite>("emerald")));


        MazoMonsterHighOponente.Add(new Card("23", 0, false, false, Card.TipoDeCarta.lider, Card.CampoDeBatalla.L, Efectos.Ganar, Resources.Load<Sprite>("TPM"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighOponente.Add(new Card("24", 7, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.MRS, Efectos.LimpiarFila, Resources.Load<Sprite>("Purrsephone"),Resources.Load<Sprite>("golden")));
        MazoMonsterHighOponente.Add(new Card("25", 6, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.MRS, Efectos.RobarCarta, Resources.Load<Sprite>("Meowlody"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighOponente.Add(new Card("26", 7, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.MR, Efectos.PromediarEIgualar, Resources.Load<Sprite>("Marisol"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighOponente.Add(new Card("27", 8, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.MS, Efectos.LimpiarFila, Resources.Load<Sprite>("Widonya"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighOponente.Add(new Card("28", 4, true, true, Card.TipoDeCarta.heroe, Card.CampoDeBatalla.MR, Efectos.RobarCarta, Resources.Load<Sprite>("Catty"), Resources.Load<Sprite>("golden")));
        MazoMonsterHighOponente.Add(new Card("29", 6, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.R, Efectos.EliminarCartaMenorPoderOponente, Resources.Load<Sprite>("Mira"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("29", 6, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.R, Efectos.EliminarCartaMenorPoderOponente , Resources.Load<Sprite>("Mira"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("29", 6, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.R, Efectos.EliminarCartaMenorPoderOponente, Resources.Load<Sprite>("Mira"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("30", 5, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.S, Efectos.MultiplicarPoderSegunCantidadDeCopias, Resources.Load<Sprite>("Joker"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("30", 5, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.S, Efectos.MultiplicarPoderSegunCantidadDeCopias, Resources.Load<Sprite>("Joker"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("30", 5, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.S, Efectos.MultiplicarPoderSegunCantidadDeCopias, Resources.Load<Sprite>("Joker"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("31", 4, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.M, Efectos.RobarCarta, Resources.Load<Sprite>("Thorne"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("31", 4, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.M, Efectos.RobarCarta, Resources.Load<Sprite>("Thorne"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("31", 4, true, false, Card.TipoDeCarta.plata, Card.CampoDeBatalla.M, Efectos.RobarCarta, Resources.Load<Sprite>("Thorne"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("32", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Deuce"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("33", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Invisibilly"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("34", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Hoodude"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("35", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Johnny"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("36", 0, false, false, Card.TipoDeCarta.senuelo, Efectos.ManoDevolver, Resources.Load<Sprite>("Toralei"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("37", 0, false, false, Card.TipoDeCarta.despeje, Efectos.DespejarClima, Resources.Load<Sprite>("Elissabat"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("38", 0, false, false, Card.TipoDeCarta.despeje, Efectos.DespejarClima, Resources.Load<Sprite>("Sirena"), Resources.Load<Sprite>("silver")));
        MazoMonsterHighOponente.Add(new Card("39", -1, false, false, Card.TipoDeCarta.clima, Card.CampoDeBatalla.C, Efectos.ActivarClima, Resources.Load<Sprite>("Operetta"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighOponente.Add(new Card("40", -1, false, false, Card.TipoDeCarta.clima, Card.CampoDeBatalla.C, Efectos.ActivarClima, Resources.Load<Sprite>("Rebecca"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighOponente.Add(new Card("41", -1, false, false, Card.TipoDeCarta.clima, Card.CampoDeBatalla.C, Efectos.ActivarClima, Resources.Load<Sprite>("Venus"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighOponente.Add(new Card("42", 2, false, false, Card.TipoDeCarta.aumento, Card.CampoDeBatalla.I, Efectos.AumentoFilaPropia, Resources.Load<Sprite>("Cupido"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighOponente.Add(new Card("43", 2, false, false, Card.TipoDeCarta.aumento, Card.CampoDeBatalla.I, Efectos.AumentoFilaPropia, Resources.Load<Sprite>("Sarah"), Resources.Load<Sprite>("emerald")));
        MazoMonsterHighOponente.Add(new Card("44", 2, false, false, Card.TipoDeCarta.aumento, Card.CampoDeBatalla.I, Efectos.AumentoFilaPropia, Resources.Load<Sprite>("Twyla"), Resources.Load<Sprite>("emerald")));
    }
}
