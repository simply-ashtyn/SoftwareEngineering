using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackObjects
{
    public class BlackjackCard : Card
    {
        public static int value { get; set; }
        public BlackjackCard(CardFace Face, CardSuit Suit) : base(Face, Suit)
        {
            Factory.CreateBlackjackCard(Face, Suit);
            switch (Face)
            {
                case CardFace.Ace:
                    value = 11;
                    break;
                case CardFace.Two:
                    value = 2;
                    break;
                case CardFace.Three:
                    value = 3;
                    break;
                case CardFace.Four:
                    value = 4;
                    break;
                case CardFace.Five:
                    value = 5;
                    break;
                case CardFace.Six:
                    value = 6;
                    break;
                case CardFace.Seven:
                    value = 7;
                    break;
                case CardFace.Eight:
                    value = 8;
                    break;
                case CardFace.Nine:
                    value = 9;
                    break;
                default:
                    value = 10;
                    break;
            }
        }
    }
}
