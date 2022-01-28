using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackObjects
{
    public class Deck
    {
        List<Card> _cards;
        public List<Card> deck;

        public void CreateAllCards()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int face = 1; face < 14; face++)
                {
                    Card newCard = Factory.CreateBlackjackCard((CardFace)face, (CardSuit)suit);
                    _cards.Add(newCard);
                }
            }
        }

        public void Shuffle()
        {
            int count = _cards.Count;
            Random rand = new Random();
            do
            {
                int rng = rand.Next(0,count + 1);
                count--;
                Card temp = _cards[rng];
                _cards[rng] = _cards[count];
                _cards[count] = temp;
            } while (count > 1);
        }

        public Deck()
        {
            _cards = new List<Card>();
            CreateAllCards();
            Shuffle();
        }

        public Card Deal()
        {
            Card dealt = deck[0];
                deck.RemoveAt(0); ;
                if (_cards.Count == 0)
                {
                    CreateAllCards();
                    Shuffle();
                }
            return dealt;
        }

    }
}
