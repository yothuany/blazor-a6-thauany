using BlazorApp.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos => Set<Produto>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("Produtos");

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(p => p.Preco)
                    .HasPrecision(10, 2);
            });
        }
    }
}