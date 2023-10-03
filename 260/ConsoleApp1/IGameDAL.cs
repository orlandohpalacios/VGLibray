//using GameLibrary.Models;
using GameDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDAL.Model
{
    public interface IGameDAL
    {

        List<Game> GetAllGameDALs();
        List<Game> SearchGames(string key);
        List<Game> FilterGames(string genre, string playform, string esrbRating);
        int AddGame(Game game);
        void Deletegame(int id);

    }
}
