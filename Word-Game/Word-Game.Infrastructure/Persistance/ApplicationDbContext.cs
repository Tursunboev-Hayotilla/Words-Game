using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word_Game.Domain.Entities;

namespace Word_Game.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Word> Words { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Username = "admin",
                    Password = "google_admin",
                    IsAdmin = true,
                    Coins = 0
                });

            modelBuilder.Entity<Level>().HasData(new List<Level>()
            {
                new Level() {Name = "Easy",Coins = 2},
                new Level() {Name = "Medium", Coins = 4},
                new Level() {Name = "Hard", Coins = 6},
            });
        }
    }
}
