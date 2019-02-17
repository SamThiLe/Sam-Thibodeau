using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwent
{
    public class Card
    {
        public Suit CardSuit { get; private set; }
        public FaceValue CardValue { get; private set; }
        public Card(FaceValue value, Suit suit)
        {
            CardValue = value;
            CardSuit = suit;
        }
        public bool IsRed()
        {
            if (CardSuit == Suit.Hearts || CardSuit == Suit.Diamonds)
                return true;
            return false;
        }
        public bool IsBlack()
        {
            if (CardSuit == Suit.Clubs || CardSuit == Suit.Spades)
                return true;
            return false;
        }
    }
}
