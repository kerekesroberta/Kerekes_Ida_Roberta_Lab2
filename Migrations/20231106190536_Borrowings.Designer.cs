﻿// <auto-generated />
using System;
using Kerekes_Ida_Roberta_Lab2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kerekes_Ida_Roberta_Lab2.Migrations
{
    [DbContext(typeof(Kerekes_Ida_Roberta_Lab2Context))]
    [Migration("20231106190536_Borrowings")]
    partial class Borrowings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int?>("PublisherID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("PublisherID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.BookCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("CategoryID");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.Publisher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.Book", b =>
                {
                    b.HasOne("Kerekes_Ida_Roberta_Lab2.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID");

                    b.HasOne("Kerekes_Ida_Roberta_Lab2.Models.Category", null)
                        .WithMany("Books")
                        .HasForeignKey("CategoryID");

                    b.HasOne("Kerekes_Ida_Roberta_Lab2.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID");

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.BookCategory", b =>
                {
                    b.HasOne("Kerekes_Ida_Roberta_Lab2.Models.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kerekes_Ida_Roberta_Lab2.Models.Category", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.Book", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.Category", b =>
                {
                    b.Navigation("BookCategories");

                    b.Navigation("Books");
                });

            modelBuilder.Entity("Kerekes_Ida_Roberta_Lab2.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
