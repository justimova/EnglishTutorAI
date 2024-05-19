﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitOfWork;

#nullable disable

namespace UnitOfWork.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240512161925_AddSourceToStoryTableAndModifyStoryParagraphTable")]
    partial class AddSourceToStoryTableAndModifyStoryParagraphTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DbModels.AiMessage", b =>
                {
                    b.Property<int>("AiMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AiMessageId"));

                    b.Property<int>("EssayId")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AiMessageId");

                    b.HasIndex("EssayId");

                    b.ToTable("AiMessages");
                });

            modelBuilder.Entity("DbModels.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Edgar Allan Poe"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "O.Henry"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Ernest Hemingway"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "F.Scott Fitzgerald"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Alice Munro"
                        },
                        new
                        {
                            AuthorId = 6,
                            AuthorName = "Jorge Luis Borges"
                        },
                        new
                        {
                            AuthorId = 7,
                            AuthorName = "Guy de Maupassant"
                        },
                        new
                        {
                            AuthorId = 8,
                            AuthorName = "Ray Bradbury"
                        },
                        new
                        {
                            AuthorId = 9,
                            AuthorName = "Flannery O'Connor"
                        },
                        new
                        {
                            AuthorId = 10,
                            AuthorName = "Shirley Jackson"
                        },
                        new
                        {
                            AuthorId = 11,
                            AuthorName = "Haruki Murakami"
                        },
                        new
                        {
                            AuthorId = 12,
                            AuthorName = "Jules Verne"
                        },
                        new
                        {
                            AuthorId = 13,
                            AuthorName = "Mark Twain"
                        },
                        new
                        {
                            AuthorId = 14,
                            AuthorName = "Stephen King"
                        },
                        new
                        {
                            AuthorId = 15,
                            AuthorName = "John Cheever"
                        },
                        new
                        {
                            AuthorId = 16,
                            AuthorName = "Isaac Asimov"
                        },
                        new
                        {
                            AuthorId = 17,
                            AuthorName = "James Joyce"
                        },
                        new
                        {
                            AuthorId = 18,
                            AuthorName = "Nathaniel Hawthorne"
                        },
                        new
                        {
                            AuthorId = 19,
                            AuthorName = "H.P.Lovecraft"
                        },
                        new
                        {
                            AuthorId = 20,
                            AuthorName = "Virginia Woolf"
                        },
                        new
                        {
                            AuthorId = 21,
                            AuthorName = "William Faulkner"
                        },
                        new
                        {
                            AuthorId = 22,
                            AuthorName = "Eudora Welty"
                        },
                        new
                        {
                            AuthorId = 23,
                            AuthorName = "Katherine Mansfield"
                        },
                        new
                        {
                            AuthorId = 24,
                            AuthorName = "Kurt Vonnegut"
                        },
                        new
                        {
                            AuthorId = 25,
                            AuthorName = "Philip K.Dick"
                        },
                        new
                        {
                            AuthorId = 26,
                            AuthorName = "Charles Bukowski"
                        },
                        new
                        {
                            AuthorId = 27,
                            AuthorName = "Roald Dahl"
                        },
                        new
                        {
                            AuthorId = 28,
                            AuthorName = "Henry James"
                        },
                        new
                        {
                            AuthorId = 29,
                            AuthorName = "Edgar Rice Burroughs"
                        },
                        new
                        {
                            AuthorId = 30,
                            AuthorName = "Truman Capote"
                        });
                });

            modelBuilder.Entity("DbModels.Essay", b =>
                {
                    b.Property<int>("EssayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EssayId"));

                    b.Property<string>("BriefText")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Recommendation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TranslatedText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EssayId");

                    b.ToTable("Essays");
                });

            modelBuilder.Entity("DbModels.Story", b =>
                {
                    b.Property<int>("StoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoryId"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("StoryId");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("DbModels.StoryParagraph", b =>
                {
                    b.Property<int>("StoryParagraphId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoryParagraphId"));

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("StoryId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranslatedText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoryParagraphId");

                    b.HasIndex("StoryId");

                    b.ToTable("StoryParagraphs");
                });

            modelBuilder.Entity("DbModels.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "53e76d80-3421-44b0-aefe-32d8ca0cab0b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "02aec1e1-a460-486a-a2e8-2d9b0fd510c2",
                            Email = "SuperAdmin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "97755fa5-7e4b-44d2-ac11-42e1c73471ea",
                            TwoFactorEnabled = false,
                            UserName = "SuperAdmin"
                        });
                });

            modelBuilder.Entity("DbModels.AiMessage", b =>
                {
                    b.HasOne("DbModels.Essay", "Essay")
                        .WithMany("AiMessages")
                        .HasForeignKey("EssayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Essay");
                });

            modelBuilder.Entity("DbModels.StoryParagraph", b =>
                {
                    b.HasOne("DbModels.Story", "Story")
                        .WithMany("Paragraphs")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Story");
                });

            modelBuilder.Entity("DbModels.Essay", b =>
                {
                    b.Navigation("AiMessages");
                });

            modelBuilder.Entity("DbModels.Story", b =>
                {
                    b.Navigation("Paragraphs");
                });
#pragma warning restore 612, 618
        }
    }
}
