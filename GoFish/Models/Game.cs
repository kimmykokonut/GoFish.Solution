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
    //public List<Player> Players { get; }
    public Game()
    {
      _deck = NewDeck();
      _instances.Add(this);
      Id = _instances.Count;
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
    public List<int> DealHand()
    {
      
      List<int> hand = new(){};
      for (int i = 0; i < 7; i++)
      {
        hand.Add(DrawCard(i));
      }
      return hand;
    }
  }
}