using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using praktika26.Classes.Common;
using praktika26.Models;
namespace praktika26.Classes
{
    public class ClubsContext : DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubsContext() =>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
