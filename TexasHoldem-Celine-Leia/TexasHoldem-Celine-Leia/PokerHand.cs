using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TexasHoldem_Celine_Leia
{
    public enum Hand
    {
        HighCard,
        OnePair,
        TwoPair,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse,
        FourOfAKind,
        StraightFlush,
        RoyalFlush

    }
    public class PokerHand
    {
        public List<Card> player1Comb = new List<Card>();
        public List<Card> player2Comb = new List<Card>();


        public PokerHand(List<Card> comCards, List<Card> player1cards, List<Card> player2cards)
        {

            foreach (Card card in comCards)
            {
                player1Comb.Add(card);
            }
            foreach (Card card in player1cards)
            {
                player1Comb.Add(card);
            }
            foreach (Card card in comCards)
            {
                player2Comb.Add(card);
            }
            foreach (Card card in player2cards)
            {
                player2Comb.Add(card);
            }
        }

        //from ChatGPT
        //prompt: "write a method that generates all possible combinations of player cards and table cards"
        //additional clarification: "with lists & not arrays please."
        public List<List<Card>> GetCombinations(List<Card> cards)
        {
            List<List<Card>> combinations = new List<List<Card>>();
            for (int i = 0; i < cards.Count - 4; i++)
            {
                for (int j = i + 1; j < cards.Count - 3; j++)
                {
                    for (int k = j + 1; k < cards.Count - 2; k++)
                    {
                        for (int l = k + 1; l < cards.Count - 1; l++)
                        {
                            for (int m = l + 1; m < cards.Count; m++)
                            {
                                List<Card> combination = new List<Card>();
                                combination.Add(cards[i]);
                                combination.Add(cards[j]);
                                combination.Add(cards[k]);
                                combination.Add(cards[l]);
                                combination.Add(cards[m]);
                                combinations.Add(combination);
                            }
                        }
                    }
                }
            }
            return combinations;
        }


    }
}
