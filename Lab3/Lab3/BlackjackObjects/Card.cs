using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackObjects
{
    public class Card
    {

        public CardSuit Suit { get; private set; }
        public CardFace Face { get; private set; }
        public int x { get; set; }
        public int y { get; set; }

        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;

            switch (Suit)
            {
                case CardSuit.Spades:
                    Suit = (CardSuit)'\u2660';
                    break;
                case CardSuit.Heart:
                    Suit = (CardSuit)'\u2665';
                    break;
                case CardSuit.Clubs:
                    Suit = (CardSuit)'\u2663';
                    break;
                case CardSuit.Diamonds:
                    Suit = (CardSuit)'\u2666';
                    break;
                default:
                    break;
            }
        }

        public void PrintCard(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.White;
            if (Suit == CardSuit.Diamonds || Suit == CardSuit.Heart)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine($" {Face}  {Suit} ");
            Console.ResetColor();
        }
    }
}
