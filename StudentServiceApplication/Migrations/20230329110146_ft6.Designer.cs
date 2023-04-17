﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudentServiceApplication;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230329110146_ft6")]
    partial class ft6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StudentServiceApplication.Models.Country", b =>
                {
                    b.Property<Guid>("InteresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("InteresId");

                    b.ToTable("Countrys");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.Interes", b =>
                {
                    b.Property<Guid>("InteresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("InteresId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.Language", b =>
                {
                    b.Property<Guid>("InteresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("InteresId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateOfBirthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Firstname")
                        .HasColumnType("text");

                    b.Property<bool?>("Gender")
                        .HasColumnType("boolean");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<byte[]>("ProfileImage")
                        .HasColumnType("bytea");

                    b.HasKey("UserId");

                    b.HasIndex("CountryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.UserInteres", b =>
                {
                    b.Property<Guid>("InteresId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("InteresId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersInteres");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.UserLanguages", b =>
                {
                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LanguageId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserLanguages");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.User", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.UserInteres", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.Interes", "Interes")
                        .WithMany()
                        .HasForeignKey("InteresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentServiceApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interes");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.UserLanguages", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentServiceApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
