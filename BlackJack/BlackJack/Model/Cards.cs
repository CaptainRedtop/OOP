using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    public class Cards
    {
        public string Suit { get; }
        public string FaceValue { get; }

        public Cards() { }
        public Cards(string suit, string faceValue)
        {
            Suit = suit;
            FaceValue = faceValue;
        }

        public int GetValue()
        {
            if (FaceValue == "Ace")
                return 11;
            if (FaceValue == "King" || FaceValue == "Queen" || FaceValue == "Jack")
                return 10;
            return int.Parse(FaceValue);
        }

        public List<Cards> CreateDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] faceValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            List<Cards> deck = new List<Cards>();

            foreach (string suit in suits)
            {
                foreach (string faceValue in faceValues)
                {
                    deck.Add(new Cards(suit, faceValue));
                }
            }

            return deck;
        }
        public int CalculateHandValue(List<Cards> hand)
        {
            int value = 0;
            int numAces = 0;

            foreach (var card in hand)
            {
                value += card.GetValue();
                if (card.FaceValue == "Ace")
                {
                    numAces++;
                }
            }

            while (numAces > 0 && value > 21)
            {
                value -= 10; // Convert Ace from 11 to 1
                numAces--;
            }

            return value;
        }
    }

}
