using CaptaTecnologia.Data.Mapping;
using CaptaTecnologia.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaptaTecnologia.Data.Context
{
    public partial class CaptaTecnologiaContext : DbContext
    {
        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<User> User { get; set; }

        public CaptaTecnologiaContext(DbContextOptions<CaptaTecnologiaContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CandidateMapping());
            modelBuilder.ApplyConfiguration(new GenderMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());

            OnModelCreatingExt(modelBuilder);
        }

        partial void OnModelCreatingExt(ModelBuilder modelBuilder);
    }
}