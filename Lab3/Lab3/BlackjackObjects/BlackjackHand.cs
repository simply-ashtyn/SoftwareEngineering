using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackObjects
{
    class BlackjackHand : Hand
    {
        public int playerScore { get; private set; }
        bool IsDealer = false;
        public BlackjackHand(bool IsDealer = false) : base()
        {

            playerScore = BlackjackCard.value;
        }

        public override void AddCard(Card card)
        {
            base.AddCard(card);
            playerScore = playerScore + BlackjackCard.value;
            if (CardFace == CardFace.Ace)
            {
                if (playerScore > 11)
                {
                    BlackjackCard.value = 1;
                }
            }
        }

        public override void PrintHand()
        {
            base.PrintHand();
            Console.WriteLine(playerScore);
            if (IsDealer == true)
            {
                
            }
        }
    }
}
