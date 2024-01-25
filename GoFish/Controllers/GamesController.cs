using Microsoft.AspNetCore.Mvc;
using GoFish.Models;
using System.Collections.Generic;

namespace GoFish.Controllers
{
  public class GamesController : Controller
  {
    [HttpGet("/games")]
    public ActionResult Index()
    {
      List<Game> allGames = Game.GetAll();
      return View(allGames);
    }
    [HttpGet("/games/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/games")]
    public ActionResult Create()
    {
      Game newGame = new Game();
      return RedirectToAction("Index"); //? 
    } //no input to start game...
    [HttpGet("/games/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Game selectedGame = Game.Find(id);
      List<Player> gamePlayer = selectedGame.Players;
      model.Add("game", selectedGame);
      model.Add("players", gamePlayer);
      return View(model);
    }
  }
}