using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using TexasHoldem_Celine_Leia;
using System.Reflection.Metadata.Ecma335;

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
    public class PokerHand : IComparable<PokerHand>
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
        //Comparing Functions
        public Hand EvalHand(List<Card> cards)
        {
            if (RoyalFlush(cards))
            {
                return Hand.RoyalFlush;
            }
            if (IsStraight(cards))
            {
                return Hand.StraightFlush;

            }
            if (FourofAKind(cards))
            {
                return Hand.FourOfAKind;
            }
            if (FullHouse(cards))
            {
                return Hand.FullHouse;
            }
            if (IsFlush(cards))
            {
                return Hand.Flush;
            }
            if (ThreeOfAKind(cards))
            {
                return Hand.ThreeOfAKind;
            }
            if (TwoPair(cards))
            {
                return Hand.TwoPair;
            }
            return Hand.HighCard;
        }
        public Hand GetBestHand(List<Card> player)
        {
            List<List<Card>> combinations = GetCombinations(player);
            Hand bestRank = Hand.HighCard;
            foreach (List<Card> combination in combinations)
            {
                Hand rank = EvalHand(combination);
                if (rank > bestRank)
                {
                    bestRank = rank;
                }
            }
            return bestRank;
        }

        public int? CompareTo(PokerHand other)
        {
            Hand thisRank = GetBestHand(player1Comb);
            Hand otherRank = other.GetBestHand(player2Comb);
            if (thisRank > otherRank)
            {
                return 1;
            }
            else if (thisRank < otherRank)
            {
                return -1;
            }
            else
            {
                List<Card> thisCards = SortCards(player1Comb);
                List<Card> otherCards = other.SortCards(player2Comb);
                for (int i = 0; i < 5; i++)
                {
                    if (thisCards[i].Face > otherCards[i].Face)
                    {
                        return 1;
                    }
                    else if (thisCards[i].Face < otherCards[i].Face)
                    {
                        return -1;
                    }
                }
                return 0;
            }
        }
        public int? Comparehands(List<Card> comCards, List<Card> player1Cards, List<Card> player2Cards)
        {
            PokerHand hand1 = new PokerHand(comCards, player1Cards, new List<Card>());
            PokerHand hand2 = new PokerHand(comCards, player2Cards, new List<Card>());
            return hand1.CompareTo(hand2);
        }
        //beginning function stuff
        public bool IsFlush(List<Card> other)
        {
            int spadeC = 0;
            int heartC = 0;
            int diamondC = 0;
            int clubc = 0;
            bool check = false;

            foreach (Card card in other)
            {
                if (card.Suit == Suit.Spades)
                {
                    spadeC++;
                }
                if (card.Suit == Suit.Diamonds)
                {
                    diamondC++;
                }
                if (card.Suit == Suit.Hearts)
                {
                    heartC++;
                }
                if (card.Suit == Suit.Clubs)
                {
                    clubc++;
                }

            }
            if (clubc == 4 || spadeC == 4 || diamondC == 4 || heartC == 4)
            {
                check = true;
            }

            return check;

        }

    

        public bool FourofAKind(List<Card> other)
        {
            bool check = false;
            int aceCount = 0;
            int twoCount = 0;
            int threeCount = 0;
            int fourCount = 0;
            int fiveCount = 0;
            int sixCount = 0;
            int sevenCount = 0;
            int eightCount = 0;
            int nineCount = 0;
            int tencount = 0;
            int jackCount = 0;
            int queenCount = 0;
            int kingCount = 0;


            foreach (Card card in other)
            {
                if (card.Face == Face.Ace)
                {
                    aceCount++;
                }
                if (card.Face == Face.Two)
                {
                    twoCount++;
                }
                if (card.Face == Face.Three)
                {
                    threeCount++;
                }
                if (card.Face == Face.Four)
                {
                    fourCount++;
                }
                if (card.Face == Face.Five)
                {
                    fiveCount++;
                }
                if (card.Face == Face.Six)
                {
                    sixCount++;
                }
                if (card.Face == Face.Seven)
                {
                    sevenCount++;
                }
                if (card.Face == Face.Eight)
                {
                    eightCount++;
                }
                if (card.Face == Face.Nine)
                {
                    nineCount++;
                }
                if (card.Face == Face.Ten)
                {
                    tencount++;
                }
                if (card.Face == Face.Jack)
                {
                    jackCount++;
                }
                if (card.Face == Face.Queen)
                {
                    queenCount++;
                }
                if (card.Face == Face.King)
                {
                    kingCount++;
                }
            }
            if (aceCount == 4 || twoCount == 4 || threeCount == 4 || fourCount == 4 || fiveCount == 4 || sixCount == 4 || sevenCount == 4 || eightCount == 4 || nineCount == 4 || tencount == 4 || jackCount == 4 || queenCount == 4 || kingCount == 4)
            {
                check = true;
            }
            return check;
        }
        public bool ThreeOfAKind(List<Card> other)
        {
            bool check = false;
            int aceCount = 0;
            int twoCount = 0;
            int threeCount = 0;
            int fourCount = 0;
            int fiveCount = 0;
            int sixCount = 0;
            int sevenCount = 0;
            int eightCount = 0;
            int nineCount = 0;
            int tencount = 0;
            int jackCount = 0;
            int queenCount = 0;
            int kingCount = 0;

            foreach (Card card in other)
            {
                if (card.Face == Face.Ace)
                {
                    aceCount++;
                }
                if (card.Face == Face.Two)
                {
                    twoCount++;
                }
                if (card.Face == Face.Three)
                {
                    threeCount++;
                }
                if (card.Face == Face.Four)
                {
                    fourCount++;
                }
                if (card.Face == Face.Five)
                {
                    fiveCount++;
                }
                if (card.Face == Face.Six)
                {
                    sixCount++;
                }
                if (card.Face == Face.Seven)
                {
                    sevenCount++;
                }
                if (card.Face == Face.Eight)
                {
                    eightCount++;
                }
                if (card.Face == Face.Nine)
                {
                    nineCount++;
                }
                if (card.Face == Face.Ten)
                {
                    tencount++;
                }
                if (card.Face == Face.Jack)
                {
                    jackCount++;
                }
                if (card.Face == Face.Queen)
                {
                    queenCount++;
                }
                if (card.Face == Face.King)
                {
                    kingCount++;
                }
            }
            if (aceCount == 3 || twoCount == 3 || threeCount == 3 || fourCount == 3 || fiveCount == 3 || sixCount == 3 || sevenCount == 3 || eightCount == 3 || nineCount == 3 || tencount == 3 || jackCount == 3 || queenCount == 3 || kingCount == 3)
            {
                check = true;
            }
            return check;
        }

        public int HighCard(List<Card> cards)
        {
            SortCards(cards);
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Face == Face.Ace)
                {
                    return (int)cards[i].Face;
                }
            }
            return (int)cards[6].Face;

        }

        public bool OnePair(List<Card> cards)
        {
            int pairCount = 0;

            for(int i = 0; i < cards.Count - 1; i++)
            {
                for(int j = 0; j < cards.Count; j++)
                {
                    if (cards[i].Face == cards[j].Face)
                    {
                        pairCount++;

                        if(pairCount == 1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool TwoPair(List<Card> cards)
        {
            int pairCount = 0;

            for (int i = 0; i < cards.Count - 1; i++)
            {
                for (int j = 0; j < cards.Count; j++)
                {
                    if (cards[i].Face == cards[j].Face)
                    {
                        pairCount++;

                        if (pairCount == 2)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public List<Card> SortCards(List<Card> cards) //Bubble sort alg
        {
            int n = cards.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (cards[j].Face > cards[j + 1].Face)
                    {
                        // Swap the cards
                        Card temp = cards[j];
                        cards[j] = cards[j + 1];
                        cards[j + 1] = temp;
                    }
                }
            }
            return cards;
        }

/*        public bool IsStraight(List<Card> Cards)
        {
            List<Card> sortedCards = new List<Card>();
            sortedCards = SortCards(Cards);
            if (sortedCards[0].Face == Face.Two && sortedCards[1].Face == Face.Three
            && sortedCards[2].Face == Face.Four && sortedCards[3].Face == Face.Five
            && sortedCards[4].Face == Face.Ace)
            {
                return true;
            }
            for (int i = 0; i < sortedCards.Count; i++)
            {
                if ((int)(sortedCards[i].Face + 1) != (int)(sortedCards[i + 1].Face))
                {
                    return false;
                }
            }

            return true;

        }*/

        //new IsStraight
        public bool IsStraight(List<Card> cards)
        {
            
            
            bool check = false;
            
            foreach (List<Card> combination in GetCombinations(cards))
            {
                SortCards(combination);
                int count = 0;
                    for (int j = 0; j < combination.Count; j++)
                    {
                        if (combination[j].Face - combination[j + 1].Face == 1)
                        {
                        count++;
                        }
                    }
                if (count == 5)
                {
                    check = true;
                }
                if (combination[0].Face == Face.Two && combination[1].Face == Face.Three
            && combination[2].Face == Face.Four && combination[3].Face == Face.Five
            && combination[4].Face == Face.Ace)
                {
                   check= true;
                }

            }
            return check;
        }


        public bool FullHouse(List<Card> Cards)
        {
            bool check = false;
            if ((OnePair(Cards) == true || TwoPair(Cards) == true) && ThreeOfAKind(Cards) == true)
            {
                check = true;
            }
            return check;
        }

        public bool StraightFlush(List<Card> Cards)
        {
            bool check = false;
            if (IsStraight(Cards) == true && IsFlush(Cards) == true)
            {
                check = true;
            }
            return check;
        }

        public bool RoyalFlush(List<Card> cards)
        {
            bool check = false;
            foreach (List<Card> combination in GetCombinations(cards))
            {
                SortCards(combination);
                
                if (combination[0].Face == Face.Ten && combination[1].Face == Face.Jack
            && combination[2].Face == Face.Queen && combination[3].Face == Face.King
            && combination[4].Face == Face.Ace)
                {
                    check = true;
                }

            }

            return check;
        }
    }
}
