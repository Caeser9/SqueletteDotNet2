﻿// <auto-generated />
using System;
using Examen.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    [DbContext(typeof(ExamenContext))]
    [Migration("20240106111006_initMig")]
    partial class initMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen.ApplicationCore.Domaine.Artiste", b =>
                {
                    b.Property<int>("ArtisteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtisteId"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nationalite")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ArtisteId");

                    b.ToTable("Artistes");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domaine.Chanson", b =>
                {
                    b.Property<int>("ChansonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChansonId"));

                    b.Property<int>("ArtisteFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateSortie")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duree")
                        .HasColumnType("int");

                    b.Property<int>("StyleMusical")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("vuesYoutube")
                        .HasColumnType("int");

                    b.HasKey("ChansonId");

                    b.HasIndex("ArtisteFk");

                    b.ToTable("Chansons");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domaine.Concert", b =>
                {
                    b.Property<int>("ArtisteFk")
                        .HasColumnType("int");

                    b.Property<int>("FestivalFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateConcert")
                        .HasColumnType("datetime2");

                    b.Property<double>("Cachet")
                        .HasColumnType("float");

                    b.Property<int>("Duree")
                        .HasColumnType("int");

                    b.HasKey("ArtisteFk", "FestivalFk", "DateConcert");

                    b.HasIndex("FestivalFk");

                    b.ToTable("Concerts");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domaine.Festival", b =>
                {
                    b.Property<int>("FestivalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FestivalId"));

                    b.Property<int>("Capacite")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FestivalId");

                    b.ToTable("Festivals");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domaine.Chanson", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domaine.Artiste", "Artiste")
                        .WithMany("Chansons")
                        .HasForeignKey("ArtisteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artiste");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domaine.Concert", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domaine.Artiste", "Artiste")
                        .WithMany("Concerts")
                        .HasForeignKey("ArtisteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domaine.Festival", "Festival")
                        .WithMany("Concerts")
                        .HasForeignKey("FestivalFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artiste");

                    b.Navigation("Festival");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domaine.Artiste", b =>
                {
                    b.Navigation("Chansons");

                    b.Navigation("Concerts");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domaine.Festival", b =>
                {
                    b.Navigation("Concerts");
                });
#pragma warning restore 612, 618
        }
    }
}
