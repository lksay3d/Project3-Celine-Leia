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
        int player2Holding;
        public Player2()
        {
            this.player2hand = new List<Card>();
            player2Holding = 100;
        }
        public int player2Bet()
        {
            player2Holding--;
            return player2Holding;
        }

        public int totalPotP2(int pot)
        {
            player2Holding = player2Holding + pot;
            return player2Holding;
        }
    }
}
