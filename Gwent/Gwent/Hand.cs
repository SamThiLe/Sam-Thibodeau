using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwent
{
    public class Hand :CardArea
    {
        public Hand()
        {
            CardLimit = 7;
            _Cards = new List<Card> { };
        }
    }
}
