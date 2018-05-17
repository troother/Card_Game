using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStone_Card_Game
{
    public class Card
    {
        private string Number;
        private string Color;

        public Card(string cardNumber, string cardColor)
        {
            Number = cardNumber;
            Color = cardColor;
        }

        public override string ToString()
        {
            return Number + "_of_" + Color;
        }
    }

}
