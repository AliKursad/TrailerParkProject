using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TrailerParkProject.Models;

namespace TrailerParkProject.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cast> Cast { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<MovieCastRelation> MovieCastRelation { get; set; }
        public virtual DbSet<MovieCategoryRelation> MovieCategoryRelation { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=movieDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cast>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<MovieCastRelation>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DirectorName).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.TrailerLink).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
