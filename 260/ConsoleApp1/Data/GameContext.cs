using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameDAL.Models;

namespace GameDAL.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
            // If we need to do sOmeThaings with options, do it here...
        }
        public DbSet<Game> GamesDb { get; set; }
    }
}
