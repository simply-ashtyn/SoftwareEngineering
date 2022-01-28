using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackObjects
{
    public class Hand
    {
        protected List<Card> _cards = new List<Card>();
        public Card card = new Card(face, suit);
        public virtual void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public virtual void PrintHand(int x, int y)
        {
            foreach (var card in _cards)
            {
                Card.PrintCard(x,y);
            }
        }
    }
}
