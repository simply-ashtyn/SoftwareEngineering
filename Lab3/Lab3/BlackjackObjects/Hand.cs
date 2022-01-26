using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackObjects
{
    public class Hand
    {
        protected List<Card> _cards;

        public virtual void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public virtual void PrintHand()
        {
            foreach (var card in _cards)
            {
                Console.Write(card);
            }
        }
    }
}
