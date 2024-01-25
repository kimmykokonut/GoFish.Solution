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
    Player newPlayer = new Player();
    Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }
  }
}