using Microsoft.EntityFrameworkCore;
using Pin.LiveSports.Core.Models;
using MatchType = Pin.LiveSports.Core.Models.MatchType;

namespace Pin.LiveSports.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Champion> Champions { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchType> MatchTypes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Player
            modelBuilder.Entity<Player>()
                .Property(b => b.Name)
                .IsRequired();

            modelBuilder.Entity<Player>()
                .Property(b => b.PlayerName)
                .IsRequired();

            modelBuilder.Entity<Player>()
                .Property(b => b.RoleId)
                .IsRequired();

            // Team
            modelBuilder.Entity<Team>()
                .Property(b => b.Name)
                .IsRequired();

            modelBuilder.Entity<Team>()
                .Property(b => b.ShortName)
                .IsRequired();

            // Role 
            modelBuilder.Entity<Role>()
                .Property(b => b.Name)
                .IsRequired();

            // Champion
            modelBuilder.Entity<Champion>()
                .Property(b => b.Name)
                .IsRequired();

            // MatchType
            modelBuilder.Entity<MatchType>()
                .Property(b => b.Name)
                .IsRequired();

            modelBuilder.Entity<MatchType>()
                .Property(b => b.ShortName)
                .IsRequired();

            modelBuilder.Entity<MatchType>()
                .Property(b => b.RequiredWins)
                .IsRequired();

            var seeder = new ApplicationSeeder();
            seeder.SeedData(modelBuilder);
        }
    }
}
