using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackObjects
{
    public class BlackjackHand : Hand
    {
        public int playerScore { get; private set; }
        public bool IsDealer = false;
        int aceCount = 0;
        Deck deck = new Deck();
        BlackjackCard BJcard = new BlackjackCard(CardFace, Suit);
        public BlackjackHand(bool IsDealer = false) : base()
        {
        }

        public override void AddCard(Card card)
        {
            base.AddCard(card);
            foreach (BlackjackCard item in _cards)
            {
                playerScore += BJcard.value;
                if (card.Face == CardFace.Ace)
                {
                    aceCount++;
                    while (playerScore > 21 && aceCount > 0)
                    {
                        playerScore -= 10;
                    }
                }
            }

        }

        public override void PrintHand(int x, int y)
        {
            if (IsDealer == true)
            {
                deck.Deal();
            }
            else
            {
                base.PrintHand(x, y);
                Console.WriteLine(playerScore);
            }


        }
    }
}
