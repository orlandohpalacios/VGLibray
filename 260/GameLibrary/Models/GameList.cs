using GameDAL.Models;

namespace GameLibrary.Models
{
    public class GameList
    {
        public List<Game> Games { get; set; }
        public GameList()
        {
            this.Games = new List<Game>();
        }
    }
}
