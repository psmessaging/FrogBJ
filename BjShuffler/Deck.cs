using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjShuffler
{
    
    public class Deck
    {
        protected List<Card> _cards = new List<Card>();

        public Deck()
        {

        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public void AddCards(List<Card> cards)
        {
            _cards.AddRange(cards);
        }

        public List<Card> GetCards()
        {
            return _cards;
        }

        public Card PopCard()
        {
            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }
    }
}
