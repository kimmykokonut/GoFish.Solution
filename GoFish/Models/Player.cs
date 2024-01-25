namespace GoFish.Models
{
  public class Player
  {
    public string Name { get; set; }
    public List<int> Hand { get; set; } = new List<int> {};
    
    public int Books = 0;
    public int Id { get; }
    private static List<Player> _instances = new List<Player> { };
    public Player(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      
    }
    public static List<Player> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Player Find(int searchId)
    {
      return _instances[searchId - 1]; 
    }

  }

}