using ChessLeague.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Talabat.Repository.Data.Contexts
{
    public class ChessLeagueDbContext : DbContext
    {
        public ChessLeagueDbContext(DbContextOptions<ChessLeagueDbContext> options)
            : base(options)
        {

        }

        public DbSet<Participant> Participants { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Round> Rounds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
