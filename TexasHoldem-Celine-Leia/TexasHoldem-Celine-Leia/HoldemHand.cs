using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexasHoldem_Celine_Leia;

namespace TexasHoldem_Celine_Leia
{
    
    public class HoldemHand
    {
        public Deck deck = new Deck();
        public Player1 player1 = new Player1();
        public Player2 player2 = new Player2();
        public List<Card> communityCard = new List<Card>();
        
        public HoldemHand(Deck deck)
        {
            player1.player1hand.Add(deck.dealCard());
            player1.player1hand.Add(deck.dealCard());
            player2.player2hand.Add(deck.dealCard());
            player2.player2hand.Add(deck.dealCard());
            for (int i = 0; i < 3; i++)
            {

                communityCard.Add(deck.dealCard());
            }
        }

        public List<Card> communityCards(Deck deck, int round = 0)
        {

            if (round == 1)
            {


                communityCard.Add(deck.dealCard());


            }
            if (round == 2)
            {
                communityCard.Add(deck.dealCard());
            }

            return communityCard;
        }
    }
}
