using GameDAL;
using GameDAL.Data;
using GameDAL.Model;
using GameDAL.Models;
using GameLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameLibrary.Controllers
{
    public class HomeController : Controller
    {
        /*        private readonly ILogger<HomeController> _logger;

                public HomeController(ILogger<HomeController> logger)
                {
                    _logger = logger;
                }*/
        GameList gameList = new GameList();
        private readonly IGameDAL dal;

        public HomeController(IGameDAL dal, GameContext context)
        {
            this.dal = new GameDefaultDAL(context);
        }

        public IActionResult Collection()
        {
            //TODO database eventually
            gameList.Games = dal.GetAllGameDALs();

            return View(gameList);
        }
        public IActionResult GameDetail(int id)
        {
            ViewBag.Games.Id = id;

            return View();
        }
        public IActionResult AddGame()
        {
            var model = new GameView();

            return View(model);
        }
        public IActionResult SearchGame(string key)
        {
            
            gameList.Games = dal.SearchGames(key);
            //if (key == null) { return View(); }
            //else
            //{
            //    //do some validating or else 
            //    ;
            //}
            return View("Collection", gameList);
        }
        public IActionResult FilterGame(string genre, string platform, string rating)
        {
           gameList.Games= dal.FilterGames(genre, platform, rating);

            return View("Collection", gameList);
        }
        public IActionResult DeleteGame(int id)
        {
          
                dal.Deletegame(id);
            gameList.Games = dal.GetAllGameDALs();
            return View("Collection", gameList);
        }
        [HttpPost]
        public IActionResult AddGame(GameView game)
        {
            var model = new Game()
            {
                Name = game.Name,
                Platform = game.Platform,
                Rating = game.Rating,

            };
            dal.AddGame(model);//not functioning?

            //send back to collection
            return View(game);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}