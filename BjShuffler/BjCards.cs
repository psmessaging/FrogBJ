using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjShuffler
{
    public class BjCards
    {
        private static readonly string[] SUITS = { "SPADE", "HEART", "CLUB", "DIAMOND" };
        private static readonly string[] CARDS = { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        private static readonly int[] CARDVALUES = { 1, 10, 10, 10, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        private static readonly string[] SPANISHCARDS = { "A", "K", "Q", "J", "9", "8", "7", "6", "5", "4", "3", "2" };
        private static readonly int[] SPANISHCARDVALUES = { 1, 10, 10, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        public static Deck CreateStandardDeck()
        {
            return CreateDeck(CARDS, CARDVALUES);
        }

        public static Deck CreateSpanishDeck()
        {
            return CreateDeck(SPANISHCARDS, SPANISHCARDVALUES);
        }

        private static Deck CreateDeck(string[] cards, int[] values)
        {
            var deck = new Deck();
            foreach (var suit in SUITS)
            {
                for (int i = 0; i < cards.Length; i++)
                {
                    var card = cards[i];
                    var value = values[i];
                    bool isAce = (value == 1);
                    deck.AddCard(new Card(suit, card, value, isAce));
                }
            }

            return deck;
        }
    }
}
