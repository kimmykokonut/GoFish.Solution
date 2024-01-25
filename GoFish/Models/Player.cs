namespace GoFish.Models
{
  public class Player
  {
    public string Name { get; set; }
    public List<int> Hand { get; set; } = new List<int> {};
    
    public int Books = 0;
    //public int Id { get; }
    public Player(string name)
    {
      Name = name;
      //Id = _instances.Count;
      
    }
  }
  
}