﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mini_Core_FiltroFechas.Data;

#nullable disable

namespace Mini_Core_FiltroFechas.Migrations
{
    [DbContext(typeof(MiniCoreGastosContext))]
    [Migration("20250109022059_Deploy")]
    partial class Deploy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mini_Core_FiltroFechas.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("departamentoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartamentoId"));

                    b.Property<string>("DepartamentoNombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("departamentoNombre");

                    b.HasKey("DepartamentoId")
                        .HasName("PK__Departam__A67AC158FF24ADC8");

                    b.ToTable("Departamento", (string)null);
                });

            modelBuilder.Entity("Mini_Core_FiltroFechas.Models.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("empleadoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpleadoId"));

                    b.Property<string>("EmpleadoNombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("empleadoNombre");

                    b.HasKey("EmpleadoId")
                        .HasName("PK__Empleado__CCDD5018E90D62A7");

                    b.ToTable("Empleado", (string)null);
                });

            modelBuilder.Entity("Mini_Core_FiltroFechas.Models.Gasto", b =>
                {
                    b.Property<int>("GastoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("gastoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GastoId"));

                    b.Property<int?>("GastoDepartamentoId")
                        .HasColumnType("int")
                        .HasColumnName("gastoDepartamentoID");

                    b.Property<string>("GastoDescripcion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("gastoDescripcion");

                    b.Property<int?>("GastoEmpleadoId")
                        .HasColumnType("int")
                        .HasColumnName("gastoEmpleadoID");

                    b.Property<DateOnly>("GastoFecha")
                        .HasColumnType("date")
                        .HasColumnName("gastoFecha");

                    b.Property<decimal>("GastoMonto")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("gastoMonto");

                    b.HasKey("GastoId")
                        .HasName("PK__Gasto__3D97892584106D8D");

                    b.HasIndex("GastoDepartamentoId");

                    b.HasIndex("GastoEmpleadoId");

                    b.ToTable("Gasto", (string)null);
                });

            modelBuilder.Entity("Mini_Core_FiltroFechas.Models.Gasto", b =>
                {
                    b.HasOne("Mini_Core_FiltroFechas.Models.Departamento", "GastoDepartamento")
                        .WithMany("Gastos")
                        .HasForeignKey("GastoDepartamentoId")
                        .HasConstraintName("FK__Gasto__gastoDepa__4E88ABD4");

                    b.HasOne("Mini_Core_FiltroFechas.Models.Empleado", "GastoEmpleado")
                        .WithMany("Gastos")
                        .HasForeignKey("GastoEmpleadoId")
                        .HasConstraintName("FK__Gasto__gastoEmpl__4D94879B");

                    b.Navigation("GastoDepartamento");

                    b.Navigation("GastoEmpleado");
                });

            modelBuilder.Entity("Mini_Core_FiltroFechas.Models.Departamento", b =>
                {
                    b.Navigation("Gastos");
                });

            modelBuilder.Entity("Mini_Core_FiltroFechas.Models.Empleado", b =>
                {
                    b.Navigation("Gastos");
                });
#pragma warning restore 612, 618
        }
    }
}
