using Laboratorio_2_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2_OOP_201902
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        

        private List<SpecialCard> weatherCards;
        
        private Dictionary<string, List<Card.Card>>[] playerCards;

        //Propiedades
        public Dictionary<string, List<Card.Card>>[] PlayerCards
        {
            get
            {
                return this.playerCards;
            }
            set
            {
                this.playerCards = value;
            }
        }
        

        //Constructor
        public Board()
        {
           
            this.weatherCards = new List<SpecialCard>();
            this.playerCards = new Dictionary<string, List<Card.Card>>[DEFAULT_NUMBER_OF_PLAYERS];
            this.playerCards[0] = new Dictionary<string, List<Card.Card>>();
            this.playerCards[1] = new Dictionary<string, List<Card.Card>>();

        }
        public void AddCard(Card.Card card, int playerId = -1, string buffType= null)
        {
            if (card.GetType().Name == nameof(CombatCard))
            {
                if (playerId == 0 || playerId == 1)
                {
                    if (playerCards[playerId].ContainsKey(card.Type))
                    {
                        playerCards[playerId][card.Type].Add(card);
                    }
                    else
                    {
                        playerCards[playerId].Add(card.Type, new List<Card.Card>() { card });
                    }

                }
                else
                {
                    throw new IndexOutOfRangeException("No player id given");
                }

            }
            else
            {

            }
        }


        //Metodos

    }
}

