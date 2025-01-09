using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mini_Core_FiltroFechas.Models;

namespace Mini_Core_FiltroFechas.Data;

public partial class MiniCoreGastosContext : DbContext
{
    public MiniCoreGastosContext()
    {
    }

    public MiniCoreGastosContext(DbContextOptions<MiniCoreGastosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Gasto> Gastos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.DepartamentoId).HasName("PK__Departam__A67AC158FF24ADC8");

            entity.ToTable("Departamento");

            entity.Property(e => e.DepartamentoId).HasColumnName("departamentoID");
            entity.Property(e => e.DepartamentoNombre)
                .HasMaxLength(50)
                .HasColumnName("departamentoNombre");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK__Empleado__CCDD5018E90D62A7");

            entity.ToTable("Empleado");

            entity.Property(e => e.EmpleadoId).HasColumnName("empleadoID");
            entity.Property(e => e.EmpleadoNombre)
                .HasMaxLength(50)
                .HasColumnName("empleadoNombre");
        });

        modelBuilder.Entity<Gasto>(entity =>
        {
            entity.HasKey(e => e.GastoId).HasName("PK__Gasto__3D97892584106D8D");

            entity.ToTable("Gasto");

            entity.Property(e => e.GastoId).HasColumnName("gastoID");
            entity.Property(e => e.GastoDepartamentoId).HasColumnName("gastoDepartamentoID");
            entity.Property(e => e.GastoDescripcion)
                .HasMaxLength(100)
                .HasColumnName("gastoDescripcion");
            entity.Property(e => e.GastoEmpleadoId).HasColumnName("gastoEmpleadoID");
            entity.Property(e => e.GastoFecha).HasColumnName("gastoFecha");
            entity.Property(e => e.GastoMonto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("gastoMonto");

            entity.HasOne(d => d.GastoDepartamento).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.GastoDepartamentoId)
                .HasConstraintName("FK__Gasto__gastoDepa__4E88ABD4");

            entity.HasOne(d => d.GastoEmpleado).WithMany(p => p.Gastos)
                .HasForeignKey(d => d.GastoEmpleadoId)
                .HasConstraintName("FK__Gasto__gastoEmpl__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
