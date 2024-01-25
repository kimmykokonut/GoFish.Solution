namespace GoFish.Models
{
  public class Player
  {
    public string Name { get; set; }
    public List<int> Hand { get; set; } = new List<int> { };

    public int Books = 0;
    public int Id { get; }
    private static List<Player> _instances = new List<Player> { };
    public Player(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;

    }

    public void MakeBook()
    {
      Hand.Sort();
      int count = 0;
      int evaluationCard = 0;
      List<int> toRemove = new();

      for (int i = 0; i < Hand.Count; i++)
      {
        if (i == 0)
        {
          evaluationCard = Hand[i];
          count++;
          continue;
        }
        if (Hand[i] == evaluationCard)
        {
          count++;
          if (count == 4)
          {
            Books++;
            count = 0;
            toRemove.Add(i);
            toRemove.Add(i - 1);
            toRemove.Add(i - 2);
            toRemove.Add(i - 3);
          }
        }
        else
        {
          evaluationCard = Hand[i];
          count = 1;
        }
      }
      foreach (int index in toRemove)
      {
        Hand.RemoveAt(index);
      }
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