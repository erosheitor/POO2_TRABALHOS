using System;
using System.Collections.Generic;
using Atacado.BD.EF.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Atacado.BD.EF.Database;

public partial class AtacadoContext : DbContext
{
    public AtacadoContext()
    {
    }

    public AtacadoContext(DbContextOptions<AtacadoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Subcategorium> Subcategoria { get; set; }

    public virtual DbSet<Regiao> Regioes { get; set; }

    public virtual DbSet<Cidade> Cidades { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=bdAtacado; User=usrAtacado; Password=senha123; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CodigoSubcategoriaNavigation).WithMany(p => p.Produtos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Produto_Subcategoria");
        });

        modelBuilder.Entity<Subcategorium>(entity =>
        {
            entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CodigoCategoriaNavigation).WithMany(p => p.Subcategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subcategoria_Categoria");
        });

        modelBuilder.Entity<Regiao>();

        modelBuilder.Entity<Cidade>();

        modelBuilder.Entity<Estado>();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
