using BlackJack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.View
{
    struct View
    {
        public void MainMenu()
        {
            //Display the main screen
            Console.WriteLine("Welcome to Blackjack\n");
            Console.WriteLine("The rules are:");
            Console.WriteLine("Get a total hand value of 21 or be the closest.\n" +
                "Picture cards are worth 10, ace is worth 11 or 1 and all other are facevalue\n" +
                "You get 2 cards and can either 'hit' to get another card or 'stand' end your turn.\n" +
                "The dealer will have one card faceup and one hidden.\n\n" +
                "Press any button to start");
            Console.ReadKey();
            Console.Clear();
        }
        public void Hand(List<Model.Cards> hand, int Score)
        {
            foreach (var card in hand)
            {
                Console.WriteLine($"{card.FaceValue} of {card.Suit}");
            }
            Console.WriteLine($"Total Value: {Score}");
            Console.WriteLine();
        }
        public void PartialHand(List<Cards> hand)
        {
            Console.WriteLine($"{hand[0].FaceValue} of {hand[0].Suit}");
            Console.WriteLine("Hidden");
            Console.WriteLine("Total Value: ?");
        }

        public string HitorStand()
        {
            while (true)
            {
                Console.WriteLine("Do you want to 'Hit' or 'Stand'?");
                string choice = Console.ReadLine().ToLower();
                if (choice == "hit" || choice == "stand")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Can't do that, try agian");
                }
            }
        }
        public void Playerbust()
        {
            Console.WriteLine("\nYou bust. Dealer takes the game");
        }
        public void PlayerWin()
        {
            Console.WriteLine("\nYou wins this game!");
        }
        public void DealerWin()
        {
            Console.WriteLine("\nDealer wins this game!");
        }

    }
}
