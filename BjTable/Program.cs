using BjShuffler;

namespace BjTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shuffler = new Shuffler();

            var decks = new DeckEx(6);
            decks = shuffler.Shuffle(decks);

            var shoe = new Shoe(decks);
            
            List<Player> players = new List<Player>();
            players.Add(new Player());
            players.Add(new Player(true));

            for (int i = 0; i < 3; i++)
            {
                foreach (var player in players)
                {
                    player.GiveCard(shoe.Deal());
                }
            }
            
            foreach (var player in players)
            {
                shoe.Discard(player.PickupCards());
            }
            Console.WriteLine("Created Decks");
        }
    }
}
