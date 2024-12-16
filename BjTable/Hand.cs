using BjShuffler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjTable
{
    public class Hand
    {
        private List<Card> _cards = new List<Card>();

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public List<Card> PickupHand()
        {
            var cards = _cards;
            _cards = new List<Card>();
            return cards;
            
        }
    }
}
