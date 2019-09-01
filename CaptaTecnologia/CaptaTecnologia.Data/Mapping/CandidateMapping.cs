using CaptaTecnologia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaptaTecnologia.Data.Mapping
{
    public class CandidateMapping : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable("Candidate", "JOB");

            builder.Property(e => e.GenderCodigo).HasMaxLength(1);

            builder.Property(e => e.LastName).HasMaxLength(50);

            builder.Property(e => e.Name).HasMaxLength(20);

            builder.HasOne(d => d.Gender)
                .WithMany(p => p.Candidate)
                .HasForeignKey(d => d.GenderCodigo)
                .HasConstraintName("FK_Candidate_Gender");
        }
    }
}
