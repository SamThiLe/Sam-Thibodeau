using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwent
{
    public class Board
    {
        private int _PlayerLives;
        private int _OpponentLives;
        public Deck TheDeck { get; set; }
        public Hand PlayerHand { get; set; }
        public Hand OpponentHand{ get; set; }
        public Field RedField { get; set; }
        public Field BlackField { get; set; }
        public bool GameOver { get; set; } = false;
        public bool PlayerPass { get; set; } = false;
        public bool OpponentPass { get; set; } = false;
        public int PlayerLives
        {
            get => _PlayerLives;
        }
        public int OpponentLives
        {
            get => _OpponentLives;
        }
        public int PlayerPoints { get; set; } 
        public int OpponentPoints { get; set; }
        public Board()
        {
            GameOver = false;
            TheDeck = new Deck();
            PlayerHand = new Hand();
            OpponentHand = new Hand();
            RedField = new Field(FieldColor.Red);
            BlackField = new Field(FieldColor.Black);
            PlayerPoints = 0;
            OpponentPoints = 0;
            _PlayerLives = 2;
            _OpponentLives = 2;
        }
        public void NewRound()
        {
            PlayerPass = false;
            OpponentPass = false;
        }
        public void EndRound()
        {
            RedField.Clear();
            BlackField.Clear();
            if (OpponentPoints>=PlayerPoints)
            {
                _PlayerLives--;
            }
            else
            {
                _OpponentLives--;
            }
            PlayerPoints = 0;
            OpponentPoints = 0;
            if (PlayerLives == 0 || OpponentLives == 0)
                GameOver = true;
        }
        public void DealHands()
        {
            PlayerHand = TheDeck.DealHand(PlayerHand.CardLimit);
            OpponentHand = TheDeck.DealHand(OpponentHand.CardLimit);
        }
        public void IPlayCard(Card card, Hand from,Field to)
        {
            int val = (int)card.CardValue+1;
            PlayerPoints += val;
            to.AddCard(card);
        }
        public int OpponentTurn()
        {
            //Opponent has more point and passes
            if (PlayerPass && OpponentPoints >= PlayerPoints)
            {
                OpponentPass = true;
                return -1;
            }
            //Opponent tries to play a card a Sligly better card
            int playedIndex;
            for (int i = 0; i < OpponentHand.Count; i++)
            {
                if (((int)OpponentHand[i].CardValue+OpponentPoints >= PlayerPoints)&&((OpponentHand[i].IsBlack()&&BlackField.Count<3)|| (OpponentHand[i].IsRed() && RedField.Count < 3)))
                {
                    OpponentPoints += (int)OpponentHand[i].CardValue+1;
                    return playedIndex = i;
                }
            }
            //Opponent 1 life and tries plays any card they can
            if (OpponentLives == 1)
            {
                for (int i = 0; i < OpponentHand.Count; i++)
                {
                    if ((OpponentHand[i].IsBlack() && BlackField.Count < 3) || (OpponentHand[i].IsRed() && RedField.Count < 3))
                    {
                        OpponentPoints += (int)OpponentHand[i].CardValue + 1;
                        return playedIndex = i;
                    }
                }
            }
            //the Opponent Pass
            OpponentPass = true;
            return -1;
        }
    }
}
