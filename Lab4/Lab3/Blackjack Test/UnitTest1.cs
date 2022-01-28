using System;
using System.Collections.Generic;
using Xunit;

namespace Blackjack_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Why won't it let me right click to quick add a unit test??
            //Why won't it let me add Blackjack Objects??

            BlackjackHand handOne = new BlackjackHand();
            BlackjackHand handTwo = new BlackjackHand();
            Deck deck = new Deck();
            Card dealt = deck.Deal();
            handOne.Add(dealt);
        }
    }
}
