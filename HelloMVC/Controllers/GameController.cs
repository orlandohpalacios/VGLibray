using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class GameController : Controller
    {
        public IActionResult GameList()
        {
            List<Game> games = new List<Game>();
            games.Add(new Game() { Id = 1, Name = "Contra" });
            games.Add(new Game() { Id = 2, Name = "life force"});
            
            ViewBag.Games = games;


            return View();
        }public IActionResult GameDetail(int id)
        {
            ViewBag.Games.Id = id;

            return View();
        }
    }
}
