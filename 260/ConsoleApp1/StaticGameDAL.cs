using GameDAL.Model;
using GameDAL.Models;
//using 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDAL
{
    public class StaticGameDAL : IGameDAL
    {

        public List<Game> games = new List<Game>()
        {           
                 new Game() { Id = 1, 
                     PhotoLink = "/Images/BDRL1.jfif", 
                     Name = "Borderlands 1", 
                     Rating = "M",
                     genre = "FPS, Action, Role-playing, Shooter",
                     Platform = "PC,Xbox,PS", 
                     year = 2009,
                     LoanPerson = "",
                     Date = ""},
                 new Game() {
                     Id = 2,
                     PhotoLink = "/Images/BRDL2.jfif",
                     Name = "Borderlands 2",
                     Rating = "M",
                      genre =  "FPS, Action, Role-playing, Shooter",
                     Platform = "PC,Xbox,PS",
                     year = 2012,
                     LoanPerson ="",
                     Date = ""
                 },
                 new Game() { 
                     Id = 3, 
                     PhotoLink = "/Images/Skyrim.jfif",
                     Name = "Skyrim", 
                     Rating = "M",
                     genre = "",
                     Platform = "PC,Xbox,PS,Switch", 
                     year = 2011,
                     LoanPerson = "Action, Role-playing", 
                     Date = ""
                 },
                 new Game() { 
                     Id = 4, 
                     PhotoLink = "/Images/ELDEN.jfif", 
                     Name = "elden Ring", 
                     Rating = "M",
                     genre = "Action, Role-playing",
                     Platform = "PC,Xbox,PS", 
                     year = 2022, 
                     LoanPerson = "", 
                     Date = ""
                 },
                 new Game() { 
                     Id = 5, 
                     PhotoLink ="/Images/CODWW2.jfif",
                     Name = "CODWW2", 
                     Rating = "M",
                      genre = "FPS, Shooter, Action, 3D",
                     Platform = "PC,Xbox,PS", 
                     year = 2017, 
                     LoanPerson = "", 
                     Date = ""
                 }
        };
        public List<Game> GetAllGameDALs()
        {
            return games;
        }
        public int AddGame(Game ngame)
        {
            ngame.Id = games.Max(p => p.Id) + 1;
           // ngame.Id = games.Count() + 1;
            
            games.Add(ngame);
            
            return ngame.Id;//works but when the collection cshtml calls it, it does not update
        }

        public void Deletegame(int id)
        {
            foreach (Game game in games.ToList()) 
            {
                if (game.Id == id) 
                {
                    games.Remove(game);
                    return;
                }
            }
        }

        public List<Game> FilterGames(string genre, string platform, string esrbRating)
        {
            List<Game> fGames = new List<Game>();
            
            foreach (Game game in games)
            {

                if (platform !=null&& game.Platform.ToLower().Contains(platform.ToLower()))
                {
                    fGames.Add(game);
                }
                else if (genre !=null &&game.genre.ToLower().Contains(genre.ToLower())) 
                {
                    fGames.Add(game);
                    
                }
                else if (esrbRating !=null && game.Rating.ToLower().Contains(esrbRating.ToLower()))
                {
                    fGames.Add(game);
                }
            }
            return fGames;
        }

        public List<Game> SearchGames(string key)
        {

            List<Game> tList = new();
            foreach (var result in games)
            {
                if (key != null)
                {
                    if (result.Name.ToLower().Contains(key.ToLower()))
                    {
                        tList.Add(result);
                    }
                }
                else
                {
                    continue;
                    //break;
                }
            }
            return tList;



            //var results= games.Where((Game) =>
            //Game.Name.ToLower().Contains(key) ||
            //Game.year.ToString().Contains(key));

            //return results.ToList();
        }
    }

}
