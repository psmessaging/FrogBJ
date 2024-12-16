namespace BjShuffler
{
    public class Shuffler
    {
        public enum SHUFFLETYPE
        {
            TRUE,
            SPLIT
        }
        public Shuffler() 
        {

        }

        public DeckEx Shuffle(DeckEx deck, SHUFFLETYPE type = SHUFFLETYPE.TRUE, int shuffles = 1)
        {
            var cards = deck.GetCards();

            switch (type)
            {
                case SHUFFLETYPE.SPLIT:
                    for (int i = 0; i < shuffles; i++)
                    {
                        cards = ShuffleSplit(cards, 4);
                    }
                    break;
                case SHUFFLETYPE.TRUE:
                default:
                    for (int i = 0; i < shuffles; i++)
                    {
                        cards = ShuffleTrue(cards);
                    }
                    break;
            }

            return new DeckEx(cards);
        }

        private List<Card> ShuffleTrue(List<Card> cards)
        {
            var left = new List<Card>();
            var right = new List<Card>();
            var result = new List<Card>();
            int mid = (int)Math.Floor((cards.Count / 2.0));
            left.AddRange(cards.GetRange(0, mid));
            right.AddRange(cards.GetRange(mid, mid));

            for (int i = 0; i < mid; i++)
            {
                result.Add(left[i]);
                result.Add(right[i]);
            }

            return result;
        }

        private List<Card> ShuffleSplit(List<Card> cards, int splits = 4)
        {
            List<Card> result = new List<Card>();
            int cnt = cards.Count / splits;
            for (int i = 0; i < splits; i++)
            {
                result.AddRange(ShuffleTrue(cards.GetRange(i * cnt, cnt)));
            }
            return result;
        }
    }
}
