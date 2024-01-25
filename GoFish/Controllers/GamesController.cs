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
    [HttpPost("/games/")]
    public ActionResult Create(string p1Name, string p2Name)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Game newGame = new Game(p1Name, p2Name);
      RouteValueDictionary route = new(){{"id", newGame.Id}};
      return RedirectToAction("Show", route);  
    }
    
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
  [HttpPost("/games/{id}/deal")]
  public ActionResult Deal(int id)
  {
    Game selectedGame = Game.Find(id);
    selectedGame.DealHand(7);
    RouteValueDictionary route = new(){{"id", id}};
    return RedirectToAction("Show", route);  
  }

    //want to stay on this page: /games/{id}/
  }
}