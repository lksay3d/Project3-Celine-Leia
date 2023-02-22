using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem_Celine_Leia
{
    public class Player2
    {
        public List<Card> player2hand { get; set; }
        int p2BetAmount;
        public Player2()
        {
            this.player2hand = new List<Card>();
            p2BetAmount = 100;
        }
    }
}
