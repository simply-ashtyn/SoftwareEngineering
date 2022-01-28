using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackObjects
{
    public class BlackjackGame
    {
        List<Card> _dealer;
        List<Card> _player;
        List<Card> _deck;
        int dealerScore = 0;
        int playerScore = 0;
        Deck deck = new Deck();
        bool playing = true;

        public void PlayRound()
        {
            do
            {
                _dealer = new List<Card>();
                _player = new List<Card>();
                _deck = new List<Card>();
                DealInitialCards();
                while (dealerScore != 21 && playerScore != 21)
                {
                    PlayersTurn();
                    DealersTurn();
                }
                DeclareWinner();
                Console.Write("Would you like to play again? Y/N");
                string play = Console.ReadLine();
                if (play == "Y" || play == "y")
                {
                    playing = true;
                }
                else
                {
                    playing = false;
                }
                Console.Clear();
            } while (playing);
        }

        public void DealInitialCards()
        {
            for (int i = 0; i < 2; i++)
            {
                i++;
                Card dealt = deck.Deal();
                _player.Add(dealt);
                foreach (var item in _player)
                {
                    PrintCard();
                }
            }
            for (int i = 0; i < 2; i++)
            {
                i++;
                Card dealt = deck.Deal();
                _dealer.Add(dealt);
            }
        }

        public void PlayersTurn()
        {
            while (playerScore < 21)
            {
                if (playerScore == 21)
                {
                    break;
                }
                Console.SetCursorPosition(x, y);
                Console.WriteLine(playerScore);
                Console.Write("Hit or Stand? ");
                string choice = Console.ReadLine();
                if (choice == "Hit")
                {
                    Card dealt = deck.Deal();
                    _player.Add(dealt);
                }
                else if (choice == "Stand")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry, try again.");
                }
            }
        }

        public void DealersTurn()
        {
            while (dealerScore < 17)
            {
                Card dealt = deck.Deal();
                _dealer.Add(dealt);
            }
        }

        public void DeclareWinner()
        {
            if (playerScore > 21)
            {
                Console.WriteLine("Dealer wins!");
            }
            else if (dealerScore > 21)
            {
                Console.WriteLine("You win!");
            }
            else if (dealerScore == playerScore)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerScore > dealerScore)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Dealer wins!");
            }
        }

        public void DrawTable()
        {

        }
    }
}
