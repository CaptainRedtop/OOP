using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    public struct Cards
    {
        public string[] Deck()
        {
            // Define the ranks and suits of a standard deck of cards
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        // Create an array to hold the cards
        string[] deck = new string[ranks.Length * suits.Length];

            // Fill the deck with cards
            int index = 0;
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck[index] = rank + " of " + suit;
                    index++;
                }
            }
            return deck;
        }

        public int GetValue()
        {
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            if (ranks[0] == "Ace")
                return 11;
            if (ranks[0] == "King" || ranks[0] == "Queen" || ranks[0] == "Jack")
                return 10;
            return int.Parse(ranks[0]);
        }
    }
}
