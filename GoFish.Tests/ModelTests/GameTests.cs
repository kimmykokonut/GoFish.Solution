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
      Game newGame = new Game("Beaufort", "Belinda");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
    [TestMethod]
    public void GetDeck_ReturnsDeck_List()
    {
      Game newGame = new("Ringo", "Bingo");
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
      Game game1 = new Game("Bonzo", "Lonzo");
      Game game2 = new Game("Mondo", "Wondo");
      List<Game> newList = new List<Game> { game1, game2 };
      List<Game> result = Game.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetGame_ReturnsGameById_Game()
    {
      Game game1 = new Game("Newman", "Frasier");
      Game game2 = new Game("Niles", "Daphne");
      Game query = Game.Find(1);
      Assert.AreEqual(game1, query);
    }
    [TestMethod]
    public void DrawCard_ReturnsCardInt_()
    {
      Game game3 = new Game("Gelaine", "Eorge");
      int card = game3.DrawCard(4);
      List<int> expectedRemainingDeck = new(){
        1, 2, 3, 4, 6 , 7 , 8, 9, 10, 11, 12, 13,
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13,
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13,
        1, 2, 3, 4, 5 , 6 , 7 , 8, 9, 10, 11, 12, 13
        };
      CollectionAssert.AreEqual(game3.Deck, expectedRemainingDeck);
      Assert.AreEqual(card, 5);
    }
    public void DealHand_ReturnsPlayerHand_List()
    {
      Game game1 = new Game("Gerry", "Jramer");
      List<int> hand = game1.DealHand(7);
      List<int> expectedHand = new(){ 1, 2, 3, 4, 5, 6, 7 };
      Assert.AreEqual(hand.Count, expectedHand.Count);
      Assert.AreEqual(game1.Deck.Count, 52 - 7);
    }
    public void RandomCard_ReturnsRandomInt_Int()
    {
      Game testGame = new Game("Bill", "Bob");

      for (int i=0; i < testGame.Deck.Count; i++)
      {
        int randomNum = testGame.RandomCard();
        Assert.IsTrue(randomNum >= 0 && randomNum < testGame.Deck.Count);
      }
    }
    public void AddPlayer_AssociatePlayerWithGame_PlayerList()
    {
      string name = "Frank";
      Player newPlayer = new Player(name);
      List<Player> newList = new List<Player> { newPlayer, newPlayer };
      Game newGame = new Game(name, name);
      List<Player> result = newGame.Players;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}