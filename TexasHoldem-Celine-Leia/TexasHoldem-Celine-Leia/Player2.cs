using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexasHoldem_Celine_Leia;

namespace TexasHoldem_Celine_Leia
{
    public class Player2
    {
        public List<Card> player2hand { get; set; }
        int player1Holding;
        public Player2()
        {
            this.player2hand = new List<Card>();
            player2Holding = 100;
        }
        public int player2Bet()
        {
            player2Holding--;
            return player1Holding;
        }

        public int totalPotP1(int pot)
        {
            player1Holding = player1Holding + pot;
            return player1Holding;
        }
    }
}
