using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    public static int round;                                         
    public bool SkipRound;                                            
    public GameObject[] NumberRound;                                 
    public GameObject panelGameOver;                                 
    public GameObject panelRound;                                    
    DataBase dataCard;                                               
    public  Player Jugador1;                                         
    public  Player Jugador2;                                          
    private Player Inicia;                                            
    private Player Finaliza;                                        
    static public Player TurnoJugador;                              

    private void CallPanelRound()                                    
    {
        StartCoroutine(PanelRound());
        IEnumerator PanelRound()
        {
            panelRound.SetActive(true);
            Transform panel = panelRound.GetComponent<CanvasGroup>().transform;
            panel.GetChild(3).GetComponent<Image>().sprite = Ganador(round).ImagenJugador;
            yield return new WaitForSeconds(3);

            panelRound.SetActive(false);
        }
    }                                   
    private void ButtonSkipTurn()                                    
    {
        TurnoJugador.Jugada = false;
        if (!SkipRound)
        {
            if (Jugador1.Turno)
            {
                Jugador1.Turno = false; Jugador2.Turno = true;
                TurnoJugador = Jugador2;
            }
            else
            {
                Jugador2.Turno = false; Jugador1.Turno = true;
                TurnoJugador = Jugador1;
            }
        }
        else
            ButtonSkipRound();
    }
    private void ButtonSkipRound()
    {
        if (Finaliza == TurnoJugador)
        {
            if (Ganador() != null)
                PanelGameOver();
            else
            {
                CallPanelRound();
                SkipRound = false;
                TurnoJugador.Jugada = false;
                if (Jugador1.PuntosAcumulados[round] > Jugador2.PuntosAcumulados[round])
                {
                    Jugador1.Turno = true; Jugador2.Turno = false;
                    TurnoJugador = Jugador1;
                    Inicia = Jugador1;
                    Finaliza = Jugador2;
                }
                else
                {
                    Jugador1.Turno = false; Jugador2.Turno = true;
                    TurnoJugador = Jugador2;
                    Inicia = Jugador2;
                    Finaliza = Jugador1;
                }
                round += 1;

                Jugador1.Cementerio();
                Jugador2.Cementerio();
                Jugador1.RobarCartas();
                Jugador2.RobarCartas();
            }
        }
        else
        {
            ButtonSkipTurn();
            SkipRound = true;
        }
    }
    private void PanelGameOver()                                    
    {
        panelGameOver.SetActive(true);
        Transform panel = panelGameOver.GetComponent<CanvasGroup>().transform;

        panel.GetChild(6).GetComponent<Text>().text = Jugador1 .PuntosAcumulados[0].ToString();
        panel.GetChild(7).GetComponent<Text>().text = Jugador1.PuntosAcumulados[1].ToString();
        panel.GetChild(8).GetComponent<Text>().text = Jugador1.PuntosAcumulados[2].ToString();

        panel.GetChild(9).GetComponent<Text>().text = Jugador2.PuntosAcumulados[0].ToString();
        panel.GetChild(10).GetComponent<Text>().text = Jugador2.PuntosAcumulados[1].ToString();
        panel.GetChild(11).GetComponent<Text>().text = Jugador2.PuntosAcumulados[2].ToString();

        if(Ganador() != null)
        panel.GetChild(18).GetComponent<Image>().sprite = Ganador().ImagenJugador;
    }
    private Player Ganador(int round)                                 
    {
        if (Jugador1.GetComponent<Player>().PuntosAcumulados[round] > Jugador2.GetComponent<Player>().PuntosAcumulados[round])
            return Jugador1;

        else return Jugador2;
    }
    private Player Ganador()                                          
    {
        int ganador1 = 0;
        int ganador2 = 0;
        for (int i = 0; i < round + 1; i++)     
        {
            if (Jugador1.PuntosAcumulados[i] > Jugador2.PuntosAcumulados[i] && Jugador1.PuntosAcumulados[i] > Jugador2.PuntosAcumulados[i])
                ganador1++;
            else if (Jugador1.PuntosAcumulados[i] < Jugador2.PuntosAcumulados[i] && Jugador1.PuntosAcumulados[i] < Jugador2.PuntosAcumulados[i])
                ganador2++;
            else { ganador1++; ganador2++; }
        }
        if (ganador1 == 2 || ganador2 == 2)
        {
            if (ganador1 > ganador2)
                return Jugador1;
            else return Jugador2;
        }
        return null;
    }
    public void ButtonGoBack() => Invoke("GoBack", 0.2f);
    private void GoBack() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    void Start()
    {
        dataCard = new DataBase();                                    
        dataCard.CreateCard();                                        
        round = 0;                                                    
    
        Jugador1.Mazo = dataCard.MazoMonsterHighJugador;                            
        Jugador2.Mazo = dataCard.MazoMonsterHighOponente;
        Inicia = Jugador1;                                              
        Finaliza = Jugador2;
        TurnoJugador = Jugador1;                                      
        Jugador1.RobarCartas();                                           
        Jugador2.RobarCartas();
    }
    void Update()
    {
    NumberRound[round].GetComponent<CanvasGroup>().alpha = 1;
    }
}
