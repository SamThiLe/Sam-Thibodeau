using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwent
{
    public class Field : CardArea
    {
        public Enum theFieldColor { get; }
        public Field(FieldColor fColor)
        {
            theFieldColor = fColor;
            CardLimit = 3;
            _Cards = new List<Card> { };
        }
        public bool IsBlack()
        {
            if (theFieldColor is FieldColor.Black)
                return true;
            return false;
        }
        public bool IsRed()
        {
            if (theFieldColor is FieldColor.Red)
                return true;
            return false;
        }
        public void Clear()
        {
            base._Cards.Clear();
        }
    }
}
