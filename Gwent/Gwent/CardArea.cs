using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwent
{
    public abstract class CardArea
    {
        protected List<Card> _Cards;
        public bool FaceUp { get; set; } = true;
        public int CardLimit { get; protected set; } = 9999;
        public int Count
        {
            get => _Cards.Count;
        } 
        public Card this[int index]
        {
            get => _Cards[index];     
        }
        public void AddCard(Card newCard)
        {
            if (_Cards.Count == CardLimit)
                throw new Exception("Card Limit exeded");
            _Cards.Add(newCard);
        }
        public void RemoveCard(int index)
        {
            if(index>_Cards.Count||index<0)
                throw new Exception("index out of range");
            _Cards.RemoveAt(index);
        }
        public void shuffle()
        {
            List<Card> holder = new List<Card> { };
            Random rng = new Random();
            while (_Cards.Count > 0)
            {
                int x = rng.Next(_Cards.Count);
                holder.Add(_Cards[x]);
                _Cards.RemoveAt(x);
            }
            _Cards = holder;
        }
    }
}
