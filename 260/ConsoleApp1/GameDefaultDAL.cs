using GameDAL.Data;
using GameDAL.Model;
using GameDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace GameDAL
{
    public class GameDefaultDAL : IGameDAL
    {
        GameContext context;

        public GameDefaultDAL(GameContext context)
        {
            this.context = context;
        }

        public int AddGame(Game game)
        {
            
            context.GamesDb.Add(game);
            context.SaveChanges();
            return game.Id;
        }

        public void Deletegame(int id)
        {
            if (id == null) return;
            var GameToDelete = context.GamesDb.Where(p => p.Id == id).FirstOrDefault();
            context.GamesDb.Remove(GameToDelete);
            context.SaveChanges();
        }


        public List<Game> FilterGames(string genre, string playform, string esrbRating)
        {
            var results = context.GamesDb
                .Where(p => p.genre.Contains(genre) ||p.Platform.Contains(playform)||p.Rating.Contains(esrbRating))
                .ToList();
            return results;
        }

        public List<Game> GetAllGameDALs()
        {
            var products = context.GamesDb.ToList();
            return products;
        }

        public List<Game> SearchGames(string key)
        {
            var results = context.GamesDb
            .Where(p => p.Name.Contains(key) || p.year.Equals(key))
              .ToList();
            return results;
        }
    }

}

