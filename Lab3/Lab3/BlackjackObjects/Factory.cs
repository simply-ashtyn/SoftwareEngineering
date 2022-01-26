using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackObjects
{
    public static class Factory
    {
        public static Card CreateCard(CardFace face, CardSuit suit)
        {
            Card newCard = new Card(face, suit);
            return newCard;
        }

        public static Card CreateBlackjackCard(CardFace face, CardSuit suit)
        {
            Card BJCard = new Card(face, suit);
            return BJCard;
        }
    }
}
