﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatrimonioSenaiTaguatinga.Context;

#nullable disable

namespace PatrimonioSenaiTaguatinga.Migrations
{
    [DbContext(typeof(PatrimonioSenaiTaguatingaContext))]
    [Migration("20220823135047_EstruturaInicial")]
    partial class EstruturaInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PatrimonioSenaiTaguatinga.Entities.Nivel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Nivel", (string)null);
                });

            modelBuilder.Entity("PatrimonioSenaiTaguatinga.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdNivel")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Senha")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("IdNivel");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("PatrimonioSenaiTaguatinga.Entities.Usuario", b =>
                {
                    b.HasOne("PatrimonioSenaiTaguatinga.Entities.Nivel", "Nivel")
                        .WithMany("Usuario")
                        .HasForeignKey("IdNivel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nivel");
                });

            modelBuilder.Entity("PatrimonioSenaiTaguatinga.Entities.Nivel", b =>
                {
                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
