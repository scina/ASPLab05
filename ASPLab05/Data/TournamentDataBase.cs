using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ASPLab05.Models.Game;

namespace ASPLab05.Data
{
    public class TournamentDataBase : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public TournamentDataBase() : base("name=BaseMDF")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }  
    }
}