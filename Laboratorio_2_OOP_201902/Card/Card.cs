﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2_OOP_201902.Card
{
    public class Card
    {
        //Atributos
        protected string name;
        protected string type;
        protected string effect;

        //Constructor
        public Card()
        {

        }
        private List<Card> cards;

        public List<Card> Cards
        {
            get
            {
                return cards;
            }
            set
            {
                cards = Cards;
            }
        }

        //Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }
        
    }
}
