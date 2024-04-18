using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
        public GameObject cardPrefab;
        public Transform deckPanel;
        public Card[] deckCards;

        void Start()
        {
            foreach (Card card in deckCards)
            {
                GameObject cardInstance = Instantiate(cardPrefab, deckPanel);
            }
        }
}
