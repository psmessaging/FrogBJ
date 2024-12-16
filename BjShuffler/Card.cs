using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjShuffler
{
    public class Card
    {
        

        private string _suit = "HEART";
        private string _card = "A";
        private int _value = 1;
        private bool _isAce = true;

        public Card(string suit, string card, int value, bool isAce)
        {
            _suit = suit;
            _card = card;
            _value = value;
            _isAce = isAce;
        }
    }
}
