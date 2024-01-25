namespace GoFish.Models 
{
  public class Game
  {
    private List<int> _deck;

    public List<int> Deck { 
      get { return _deck;} 
    }
    private static List<Game> _instances = new List<Game> {};
    public int Id { get; }
    public List<Player> Players { get; set; }
    public Game(string name, string name2)
    {
      _deck = NewDeck();
      _instances.Add(this);
      Id = _instances.Count;
      Players = new List<Player> { new Player(name), new Player(name2) };
    }
    
    public static List<int> NewDeck()
    {
      return new(){
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13,
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13,
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13,
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13
        };
    }
    public int DrawCard(int index)
    {
      int card = Deck[index];
      Deck.RemoveAt(index);
      return card;
    }
    public void DealHand(int amount)
    {
      foreach (Player player in Players) {
        List<int> hand = new(){};
        for (int i = 0; i < amount; i++)
        {
          hand.Add(DrawCard(RandomCard()));
        }
        player.Hand = hand;
      }
    }

    public int RandomCard()
    {
      Random random = new();
      return random.Next(Deck.Count);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Game> GetAll()
    {
      return _instances;
    }
    public static Game Find(int id)
    {
      return _instances[id - 1];
    }

  }
}