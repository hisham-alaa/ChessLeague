using ChessLeague.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Talabat.Repository.Data.Configurations
{
    public class MatchConfigurations : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.ScheduledTime)
                  .IsRequired();

            builder.Property(m => m.Result)
                  .HasMaxLength(100);

            builder.Property(m => m.IsClosed)
                  .IsRequired();

            builder.HasOne(m => m.Round)
                  .WithMany(r => r.Matches)
                  .HasForeignKey(m => m.RoundId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Participant>()
                  .WithMany()
                  .HasForeignKey(m => m.Player1Id)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Participant>()
                  .WithMany()
                  .HasForeignKey(m => m.Player2Id)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Participant>()
                  .WithMany()
                  .HasForeignKey(m => m.WinnerId)
                  .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
