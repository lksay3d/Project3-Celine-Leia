﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem_Celine_Leia
{
    public enum Suit {
        Diamonds,
        Hearts,
        Spades,
        Clubs
    }

    public enum Face {
       Two=2,
       Three,
       Four,
       Five,
       Six,
       Seven,
       Eight,
       Nine,
       Ten,
       Jack,
       Queen,
       King,
       Ace


    }


    public class Card //Eric C gitHub link-
    {
        
        public Face Face { get; set; }
        public Suit Suit { get; set; }
        public Suit suit;
        public Face face;


        public Card(Suit suit, Face face)
        {
            this.suit = suit;
            this.face = face;
        }

        public override string ToString()
        {
            return $"{face} of {suit}";
        }



    }

    public class Deck
    {
        public List<Card> deck;
        int cardNum = 0;
        public Deck()
        {

            deck = new List<Card>();
            Suit[] suits = Enum.GetValues<Suit>();
            Face[] faces = Enum.GetValues<Face>();

            foreach (Suit suit in suits)
            {
                foreach(Face face in faces)
                {
                    Card card= new Card(suit, face);
                    deck.Add(card);

                }
            }

        }

        //deal cards to table only
       public Card dealCard()
        {
            
            Random random = new Random();
            int randomIndex = random.Next(1, (53 + cardNum));
            Card card = deck[randomIndex];
            deck.RemoveAt(randomIndex);
            cardNum--;

            return card;
        }


       public int CardsLeft()
        {
            return cardNum;
        }
            



        
    }
}
