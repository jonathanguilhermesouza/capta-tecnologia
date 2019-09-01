using CaptaTecnologia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaptaTecnologia.Data.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "ACCOUNT");
            builder.Property(e => e.Password).HasMaxLength(10);
            builder.Property(e => e.Username).HasMaxLength(20);
        }
    }
}
