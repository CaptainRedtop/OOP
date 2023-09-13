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
        Model.Cards card = new Model.Cards();
        List<Cards> playerHand = new List<Cards>();
        List<Cards> dealerHand = new List<Cards>();
        View.View gui = new View.View();
        public void StartController()
        {
            gui.MainMenu();
            List<Cards> deck = card.CreateDeck();
            ShuffleDeck(deck);
            MainGame(deck);
        }
        private void MainGame(List<Cards> deck)
        {
            // Deal initial cards
            playerHand.Add(DealCard(deck));
            dealerHand.Add(DealCard(deck));
            playerHand.Add(DealCard(deck));
            dealerHand.Add(DealCard(deck));
            int playerScore = card.CalculateHandValue(playerHand);
            int dealerScore = card.CalculateHandValue(dealerHand);
            //Show hands
            gui.Hand(playerHand, playerScore);
            gui.PartialHand(dealerHand);

            //Player turn
            while (card.CalculateHandValue(playerHand) < 21)
            {
                if (gui.HitorStand() == "hit")
                {
                    playerHand.Add(DealCard(deck));
                    playerScore = card.CalculateHandValue(playerHand);
                    gui.Hand(playerHand, playerScore);
                }
                else
                {
                    break;
                }
            }

            //Dealer's turn
            while (card.CalculateHandValue(dealerHand) < 17)
            {
                dealerHand.Add(DealCard(deck));
            }

            //Final hands
            dealerScore = card.CalculateHandValue(dealerHand);
            gui.Hand(playerHand, playerScore);
            gui.Hand(dealerHand, dealerScore);

            //Winner
            int playerValue = card.CalculateHandValue(playerHand);
            int dealerValue = card.CalculateHandValue(dealerHand);

            if (playerValue > 21)
            {
                gui.Playerbust();
                Console.ReadKey();
            }
            else if (dealerValue > 21 || playerValue > dealerValue)
            {
                gui.PlayerWin();
                Console.ReadKey();
            }
            else if(dealerValue > playerValue)
            {
                gui.DealerWin();
                Console.ReadKey();
            }
            else
            {
                gui.DealerWin();
                Console.ReadKey();
            }

        }
        private void ShuffleDeck(List<Cards> deck)
        {
            Random rng = new Random();
            int i = deck.Count;
            while (i > 1)
            {
                i--;
                int x = rng.Next(i + 1);
                Cards card = deck[x];
                deck[x] = deck[i];
                deck[i] = card;
            }
        }
        private Cards DealCard(List<Cards> deck)
        {
            card = deck.First();
            deck.RemoveAt(0);
            return card;
        }

    }
}
