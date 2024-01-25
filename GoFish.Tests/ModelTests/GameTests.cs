using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models; 

namespace GoFish.Tests
{ 
  [TestClass]
  public class GameTests : IDisposable
  {
    public void Dispose() 
    {
      Game.ClearAll();
    }
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
    [TestMethod]
    public void GetDeck_ReturnsDeck_List()
    {
      Game newGame = new();
      List<int> expectedDeck = new(){
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13,
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13,
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13,
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13
        };
      CollectionAssert.AreEqual(newGame.Deck, expectedDeck);
    }
    [TestMethod]
    public void GetAll_ReturnsAllGameObjects_GameList()
    {
      Game game1 = new Game();
      Game game2 = new Game();
      List<Game> newList = new List<Game> { game1, game2 };
      List<Game> result = Game.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    // [TestMethod]
    // public void
  }
}