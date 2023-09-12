using BlackJack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Controller
{
    public class Controller
    {
        Model.Cards cards = new Model.Cards();
        View.View gui = new View.View();

        public void StartController()
        {
            gui.MainMenu();
            MainGame();
        }
        public void MainGame()
        {
            //Creating the deck
            string[] deck = cards.Deck();
            //Shuffle the deck
            ShuffleDeck(deck);
            //Give cards
            string[] playerhand = new string[5];
            string[] dealerhand = new string[5];
            playerhand[0] = deck[0];
            dealerhand[0] = deck[1];
            playerhand[1] = deck[2];
            dealerhand[1] = deck[3];
            //GameStart
            int playerscore = CalculateHandValue(playerhand);
            int dealerscore = CalculateHandValue(dealerhand);
            gui.Hands(playerhand, dealerhand, playerscore, dealerscore);
            char choice = Convert.ToChar(Console.Read());
            while (playerscore < 21)
            {
                if (choice == 'h')
                {
                    Console.Clear();
                    playerhand[2] = deck[4];
                    playerscore = CalculateHandValue(playerhand);
                    gui.Hands(playerhand, dealerhand, playerscore, dealerscore);
                    Console.Read();
                }
                else if (choice == 's')
                {
                    break;
                }
            }
        }
        public string[] ShuffleDeck(string[] deck)
        {
            Random rng = new Random();
            int n = deck.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string temp = deck[k];
                deck[k] = deck[n];
                deck[n] = temp;
            }
            return deck;
        }

        public int CalculateHandValue(string[] hand)
        {
            int value = 0;
            int numAces = 0;

            foreach (var card in hand)
            {
                value += cards.GetValue();
                if (hand.Contains("Ace"))
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
