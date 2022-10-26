using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace caserito_finder.Models
{
    public partial class bd_proyectoContext : DbContext
    {
        public bd_proyectoContext()
        {
        }

        public bd_proyectoContext(DbContextOptions<bd_proyectoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Form> Forms { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Form>(entity =>
            {
                entity.ToTable("form");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Desde).HasColumnType("int(11)");

                entity.Property(e => e.Direccion).HasMaxLength(255);

                entity.Property(e => e.DueñoNegocio)
                    .HasMaxLength(255)
                    .HasColumnName("Dueño_Negocio");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Hasta).HasColumnType("int(11)");

                entity.Property(e => e.NombreNegocio)
                    .HasMaxLength(255)
                    .HasColumnName("Nombre_Negocio");

                entity.Property(e => e.Telefono).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
