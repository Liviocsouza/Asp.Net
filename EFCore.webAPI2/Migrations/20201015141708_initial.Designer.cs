﻿// <auto-generated />
using System;
using EFCore.webAPI2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.webAPI2.Migrations
{
    [DbContext(typeof(HeroiContext))]
    [Migration("20201015141708_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.webAPI2.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeroiId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("EFCore.webAPI2.Models.Batalha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("DtFim");

                    b.Property<DateTime>("DtInicio");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("EFCore.webAPI2.Models.Heroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BatalhaId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("BatalhaId");

                    b.ToTable("Herois");
                });

            modelBuilder.Entity("EFCore.webAPI2.Models.Arma", b =>
                {
                    b.HasOne("EFCore.webAPI2.Models.Heroi", "Heroi")
                        .WithMany()
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCore.webAPI2.Models.Heroi", b =>
                {
                    b.HasOne("EFCore.webAPI2.Models.Batalha", "Batalha")
                        .WithMany()
                        .HasForeignKey("BatalhaId");
                });
#pragma warning restore 612, 618
        }
    }
}
