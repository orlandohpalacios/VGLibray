using GameDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDAL.Data
{
    public class DbInitializer
    {
        public static void Initialize(GameContext context)
        {
            context.Database.EnsureCreated();
            
            SetupGames(context);
           
        }


        public static void SetupGames(GameContext context) //add games
        {
     
            if (context.GamesDb.Any())
            {
                return;
            }
            var games = new List<Game>()
            {
                 new Game() {
                     PhotoLink = "/Images/BDRL1.jfif",
                     Name = "Borderlands 1",
                     Rating = "M",
                     genre = "FPS, Action, Role-playing, Shooter",
                     Platform = "PC,Xbox,PS",
                     year = 2009,
                     LoanPerson = "",
                     Date = ""},
                 new Game() {

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

                     PhotoLink ="/Images/CODWW2.jfif",
                     Name = "CODWW2",
                     Rating = "M",
                      genre = "FPS, Shooter, Action, 3D",
                     Platform = "PC,Xbox,PS",
                     year = 2017,
                     LoanPerson = "",
                     Date = ""
                 } };
            foreach (var game in games) 
            {
                //context.GamesDb.Add(game);
                context.GamesDb.Add(game);//maybe it works
            }
            context.SaveChanges();
        }

    }
}

