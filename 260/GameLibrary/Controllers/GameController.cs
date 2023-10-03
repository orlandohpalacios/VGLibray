using GameLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GameDAL;
using GameDAL.Model;
using GameDAL.Models;

namespace GameLibrary.Controllers
{
    public class GameController : Controller
    {
       private readonly IGameDAL dal;

        public GameController(IGameDAL dal) 
        {
            this.dal = dal;
        }

        public IActionResult Collection()
        {
            //TODO database eventually

            GameList gameList = new GameList();
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
        public IActionResult AddGame(GameView game)
        {
            var model = new Game()
            {
                Name = game.Name,
                Platform = game.Platform,
                Rating = game.Rating,

            };
            dal.AddGame(model);

            //send back to collection
            return View();
        }
    }
}