using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;

namespace GoFish.TestTools
{
  [TestClass]
  public class PlayerTests
  {
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
  }
}