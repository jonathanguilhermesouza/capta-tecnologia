using CaptaTecnologia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaptaTecnologia.Data.Mapping
{
    public class GenderMapping : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.ToTable("Gender", "SIS");

            builder.HasKey(e => e.Codigo);

            builder.Property(e => e.Codigo)
                .HasMaxLength(1)
                .ValueGeneratedNever();

            builder.Property(e => e.Description).HasMaxLength(9);
        }
    }
}
