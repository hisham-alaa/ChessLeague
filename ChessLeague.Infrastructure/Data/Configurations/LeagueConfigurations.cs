using ChessLeague.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Talabat.Repository.Data.Configurations
{
    public class LeagueConfigurations : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Name)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(l => l.StartDate)
                  .IsRequired();

            builder.Property(l => l.EndDate)
                  .IsRequired();

            builder.HasOne<Participant>()
                  .WithMany()
                  .HasForeignKey(l => l.ChampionId)
                  .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
