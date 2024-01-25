using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models; 

namespace GoFish.Tests
{ 
  [TestClass]
  public class GameTests 
  {
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
  }
}