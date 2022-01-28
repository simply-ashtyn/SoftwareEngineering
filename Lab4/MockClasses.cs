using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockClasses
{
    public interface ICard
    {

    }

    public class Deck
    {
        public void Shuffle()
        {
        }

        public ICard Deal()
        {
            return null;
        }
    }

    public class BlackjackHand
    {
        public int Score { get; set; }
        public bool IsDealer { get; set; }
        public BlackjackHand(bool isDealer = false)
        {
        }

        public void AddCard(ICard card)
        {
        }

        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("[nothing to draw]");
        }
    }
}
