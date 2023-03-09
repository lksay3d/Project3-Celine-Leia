using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexasHoldem_Celine_Leia;

namespace TexasHoldem_Celine_Leia
{
    public class Player1
    {
        public List<Card> player1hand { get; set; }
        public int player1Holding;
        public Player1()
        {
            this.player1hand = new List<Card>();
            player1Holding = 100;
        }

        public int player1Bet()
        {
            player1Holding--;
            return player1Holding;
        }

        public int totalPotP1(int pot)
        {
            player1Holding = player1Holding + pot;
            return player1Holding;
        }
    }
}
