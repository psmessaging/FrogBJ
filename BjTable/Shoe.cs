using BjShuffler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjTable
{
    public class Shoe
    {
        private Discard _discard = new Discard();
        private DeckEx _decks;

        public Shoe(DeckEx deck)
        {
            _decks = deck;
        }

        public Card Deal()
        {
            return _decks.PopCard();
        }

        public void Discard(List<Card> cards)
        {
            _discard.AddCards(cards);
        }
    }
}
