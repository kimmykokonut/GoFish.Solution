using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;

namespace GoFish.TestTools
{
  [TestClass]
  public class PlayerTests : IDisposable
  {
    public void Dispose()
    {
      Player.ClearAll();
    }
    [TestMethod]
    public void PlayerConstructo_CreatesInstanceOfGame_Game()
    {
      Player newPlayer = new Player("Xena");
      Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Xena";
      Player newPlayer = new Player(name);
      string result = newPlayer.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "Xena";
      Player newPlayer = new Player(name);
      string updatedName = "Gabrielle";
      newPlayer.Name = updatedName;
      string result = newPlayer.Name;
      Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void GetHand_ReturnsHand_List()
    {
      string name = "Xena";
      Player newPlayer = new Player(name);
      List<int> playerHand = newPlayer.Hand;
      List<int> expectedHand = new();
      CollectionAssert.AreEqual(playerHand, expectedHand);
    }
    [TestMethod]
    public void SetHand_SetsValueOfHand_List()
    {
      string name = "Xena";
      Player newPlayer = new Player(name);
      List<int> updatedHand = new(){ 1, 4 };
      newPlayer.Hand = updatedHand;
      List<int> expectedHand = newPlayer.Hand;
      CollectionAssert.AreEqual(updatedHand, expectedHand);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlayerList()
    {
      List<Player> newList = new List<Player> { };
      List<Player> result = Player.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsPlayers_PlayerList()
    {
      Player newPlayer1 = new Player("George");
      Player newPlayer2 = new Player("Jerry");
      List<Player> newList = new List<Player> { newPlayer1, newPlayer2 };
      List<Player> result = Player.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_PlayersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string name = "Elaine";
      Player newPlayer = new Player(name);
      int result = newPlayer.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      string name1 = "Kramer";
      string name2 = "Newman";
      Player newPlayer1 = new Player(name1);
      Player newPlayer2 = new Player(name2);
      Player result = Player.Find(2);
      Assert.AreEqual(newPlayer2, result);
    }
    [TestMethod]
    public void MakeBook_TakesHandConvertsToBook_Void()
    {
      Player puddy = new Player("Puddy");
      puddy.Hand = new List<int>(){4, 3, 3, 2, 3, 3};
      List<int> expected = new List<int>(){2, 4};
      puddy.MakeBook();
      Assert.AreEqual(puddy.Books, 1);
      CollectionAssert.AreEqual(expected, puddy.Hand);
    }
  }
}