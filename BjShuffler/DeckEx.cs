using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjShuffler
{
    public class DeckEx : Deck
    {
        public DeckEx(int deckCount, bool isSpanish = false)
        {
            for (int i = 0; i < deckCount; i++)
            {
                if (isSpanish)
                {
                    _cards.AddRange(BjCards.CreateSpanishDeck().GetCards());
                } else
                {
                    _cards.AddRange(BjCards.CreateStandardDeck().GetCards());
                }
            }
        }

        public DeckEx(List<Card> cards)
        {
            _cards.AddRange(cards);
        }
    }
}
