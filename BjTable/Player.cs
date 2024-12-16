using BjShuffler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjTable
{
    public class Player
    {
        private bool _isDealer = false;
        private Hand _hand = new Hand();

        public Player(bool isDealer = false)
        {
            _isDealer = isDealer;
        }

        public void GiveCard(Card card)
        {
            _hand.AddCard(card);
        }

        public List<Card> PickupCards()
        {
            return _hand.PickupHand();
        }
    }
}
