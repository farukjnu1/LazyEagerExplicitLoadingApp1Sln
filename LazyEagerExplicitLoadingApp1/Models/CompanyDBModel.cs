using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LazyEagerExplicitLoadingApp1.Models
{
    public partial class CompanyDBModel : DbContext
    {
        public CompanyDBModel()
            : base("name=CompanyDBContext")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyLocation> CompanyLocations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyLocations)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);
        }
    }
}
