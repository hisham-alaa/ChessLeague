using ChessLeague.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Talabat.Repository.Data.Configurations
{
    public class ParticipantConfigurations : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(p => p.Rating)
                  .IsRequired();

            builder.Property(p => p.JoinDate)
                  .IsRequired();

            builder.HasOne(p => p.Group)
                  .WithMany(g => g.Participants)
                  .HasForeignKey(p => p.GroupId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
