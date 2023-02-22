using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem_Celine_Leia
{
    public class HoldemHand
    {
        public Deck deck = new Deck();
        public Player1 player1 = new Player1();
        public Player2 player2 = new Player2();
        public HoldemHand()
        {
            player1.player1hand.Add(deck.dealCard());
            player1.player1hand.Add(deck.dealCard());
            player2.player2hand.Add(deck.dealCard());
            player2.player2hand.Add(deck.dealCard());

        }
     
    }
}
