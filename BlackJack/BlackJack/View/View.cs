using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.View
{
    public class View
    {
        public void MainMenu()
        {
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
        public void Hands(string[] player, string[] dealer, int playerScore, int dealerScore)
        {
            Console.WriteLine("Your hand is:");
            for (uint i = 0; i < player.Length; i++)
            {
                Console.WriteLine(player[i]);
            }
            Console.WriteLine("Your total handscore is: " + playerScore + "\n");
            Console.WriteLine("Dealers hand is: ");
            Console.WriteLine(dealer.First());
            Console.WriteLine("Hidden\n");
            Console.WriteLine("What do you want to hit or stand? 'h/s'");
        }
    }
}
