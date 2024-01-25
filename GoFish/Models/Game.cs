namespace GoFish.Models 
{
  public class Game
  {
    
    private List<int> _deck;
    public List<int> Deck { 
      get { return _deck;} 
    }
    public Game()
    {
      _deck = NewDeck();
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
    // public int DrawCard()
    // {

    // }
    // public List<int> DealHand(int amount)
    // {

    // }
  }
}