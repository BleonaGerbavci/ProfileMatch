﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SoftwareDesignProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230204223448_AnkesaRelation")]
    partial class AnkesaRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.Ankesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("NumriPersonal")
                        .HasColumnType("int");

                    b.Property<string>("Permbajtja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentiNrLeternjoftimit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentiNrLeternjoftimit");

                    b.ToTable("Ankesat");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.Aplikimi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ApplyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<string>("SpecialCategoryReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentiNrLeternjoftimit")
                        .HasColumnType("int");

                    b.Property<bool>("isSpecialCategory")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("StudentiNrLeternjoftimit");

                    b.ToTable("Aplikimet");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.Fakulteti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Departamenti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drejtimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fakultetet");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.FileDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FileData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FileDetails");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FileDetails");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.ProfileMatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AplikimiId")
                        .HasColumnType("int");

                    b.Property<int>("ExtraPoints")
                        .HasColumnType("int");

                    b.Property<int>("PointsForCity")
                        .HasColumnType("int");

                    b.Property<int>("PointsForGPA")
                        .HasColumnType("int");

                    b.Property<int>("TotalPoints")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AplikimiId");

                    b.ToTable("ProfileMatch");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.Student", b =>
                {
                    b.Property<int>("NrLeternjoftimit")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmriIPrindit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FakultetiId")
                        .HasColumnType("int");

                    b.Property<string>("Gjinia")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Mbiemri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NotaMesatare")
                        .HasColumnType("float");

                    b.Property<int>("NumriKontaktues")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePicUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qyteti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Statusi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VitiIStudimeve")
                        .HasColumnType("int");

                    b.HasKey("NrLeternjoftimit");

                    b.HasIndex("FakultetiId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.PDF", b =>
                {
                    b.HasBaseType("SoftwareDesignProject.Data.Models.FileDetails");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("PDF");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.PNG", b =>
                {
                    b.HasBaseType("SoftwareDesignProject.Data.Models.FileDetails");

                    b.Property<DateTime>("DateUploaded")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("PNG");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.Ankesa", b =>
                {
                    b.HasOne("SoftwareDesignProject.Data.Models.Student", "Studenti")
                        .WithMany()
                        .HasForeignKey("StudentiNrLeternjoftimit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studenti");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.Aplikimi", b =>
                {
                    b.HasOne("SoftwareDesignProject.Data.Models.FileDetails", "FileDetails")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoftwareDesignProject.Data.Models.Student", "Studenti")
                        .WithMany()
                        .HasForeignKey("StudentiNrLeternjoftimit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FileDetails");

                    b.Navigation("Studenti");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.ProfileMatch", b =>
                {
                    b.HasOne("SoftwareDesignProject.Data.Models.Aplikimi", "Aplikimi")
                        .WithMany()
                        .HasForeignKey("AplikimiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aplikimi");
                });

            modelBuilder.Entity("SoftwareDesignProject.Data.Models.Student", b =>
                {
                    b.HasOne("SoftwareDesignProject.Data.Models.Fakulteti", "Fakulteti")
                        .WithMany()
                        .HasForeignKey("FakultetiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fakulteti");
                });
#pragma warning restore 612, 618
        }
    }
}
