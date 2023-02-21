using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem_Celine_Leia
{
    public class Player1
    {
        public List<Card> player1hand { get; set; }
        public Player1()
        {
            this.player1hand = new List<Card>();
        }
    }
}
