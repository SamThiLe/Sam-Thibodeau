using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwent
{
    public class Deck : CardArea
    {


        public Deck()
        {
            _Cards = new List<Card>();
            MakeDeck();
        }
        public void MakeDeck()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int facevalue = 0; facevalue < 13; facevalue++)
                {
                    Card inCard = new Card((FaceValue)facevalue, (Suit)suit);
                    _Cards.Add(inCard);
                }
            }
        }
        public Hand DealHand(int numCards)
        {
            if (numCards > _Cards.Count)
                throw new Exception("There are not enough cards in the deck to deal a new " + numCards + " card hand.");
            Hand newHand = new Hand();
            for (int i = 0; i < numCards; i++)
            {
                newHand.AddCard(DrawOneCard());
            }
            return newHand;
        }
        public Card DrawOneCard()
        {
            if (_Cards.Count == 0)
            {
                throw new Exception("The Deck Is Empty.");
            }
            Card theCard = _Cards[0];
            _Cards.RemoveAt(0);
            return theCard;
        }
    }
}
