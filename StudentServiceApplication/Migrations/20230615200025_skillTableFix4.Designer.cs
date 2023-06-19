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
    [Migration("20230615200025_skillTableFix4")]
    partial class skillTableFix4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InteresUser", b =>
                {
                    b.Property<Guid>("InterestsInteresId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UsersUserId")
                        .HasColumnType("uuid");

                    b.HasKey("InterestsInteresId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("InteresUser");
                });

            modelBuilder.Entity("LanguageUser", b =>
                {
                    b.Property<Guid>("LanguagesLanguageId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UsersUserId")
                        .HasColumnType("uuid");

                    b.HasKey("LanguagesLanguageId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("LanguageUser");
                });

            modelBuilder.Entity("SkillUser", b =>
                {
                    b.Property<Guid>("HavingSkillsSkillId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("HavingUsersUserId")
                        .HasColumnType("uuid");

                    b.HasKey("HavingSkillsSkillId", "HavingUsersUserId");

                    b.HasIndex("HavingUsersUserId");

                    b.ToTable("SkillUser");
                });

            modelBuilder.Entity("SkillUser1", b =>
                {
                    b.Property<Guid>("NeedingSkillsSkillId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("NeedingUsersUserId")
                        .HasColumnType("uuid");

                    b.HasKey("NeedingSkillsSkillId", "NeedingUsersUserId");

                    b.HasIndex("NeedingUsersUserId");

                    b.ToTable("SkillUser1");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.Country", b =>
                {
                    b.Property<Guid>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.Institute", b =>
                {
                    b.Property<Guid>("IstituteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IstituteId");

                    b.ToTable("Institutes");
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
                    b.Property<Guid>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.Message", b =>
                {
                    b.Property<Guid>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateSent")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MessageText")
                        .HasColumnType("text");

                    b.Property<Guid>("RecepientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("uuid");

                    b.HasKey("MessageId");

                    b.HasIndex("RecepientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.Skill", b =>
                {
                    b.Property<Guid>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SkillId");

                    b.ToTable("WantedSkill", (string)null);
                });

            modelBuilder.Entity("StudentServiceApplication.Models.TranslatePhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<byte[]>("OriginalImage")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("TranslateImage")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TranslatePhotos");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("InstituteId")
                        .HasColumnType("uuid");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("CountryId");

                    b.HasIndex("InstituteId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InteresUser", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.Interes", null)
                        .WithMany()
                        .HasForeignKey("InterestsInteresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentServiceApplication.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LanguageUser", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentServiceApplication.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkillUser", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("HavingSkillsSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentServiceApplication.Models.User", null)
                        .WithMany()
                        .HasForeignKey("HavingUsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkillUser1", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("NeedingSkillsSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentServiceApplication.Models.User", null)
                        .WithMany()
                        .HasForeignKey("NeedingUsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentServiceApplication.Models.Message", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.User", "Recepient")
                        .WithMany("ReceivedMessage")
                        .HasForeignKey("RecepientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentServiceApplication.Models.User", "Sender")
                        .WithMany("SentMessage")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recepient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.TranslatePhoto", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.User", "User")
                        .WithMany("TranslatePhotos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.User", b =>
                {
                    b.HasOne("StudentServiceApplication.Models.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentServiceApplication.Models.Institute", "Institute")
                        .WithMany("Users")
                        .HasForeignKey("InstituteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("StudentServiceApplication.Models.UserProfile", "UserProfile", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uuid");

                            b1.Property<byte?>("Course")
                                .HasColumnType("smallint");

                            b1.Property<DateTime?>("DateOfBirthday")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<string>("Description")
                                .HasColumnType("text");

                            b1.Property<string>("Firstname")
                                .HasColumnType("text");

                            b1.Property<bool?>("Gender")
                                .HasColumnType("boolean");

                            b1.Property<string>("Lastname")
                                .HasColumnType("text");

                            b1.Property<string>("PhoneNumber")
                                .HasColumnType("text");

                            b1.Property<byte[]>("ProfileImage")
                                .HasColumnType("bytea");

                            b1.Property<string>("StudyDirection")
                                .HasColumnType("text");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Country");

                    b.Navigation("Institute");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.Country", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.Institute", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("StudentServiceApplication.Models.User", b =>
                {
                    b.Navigation("ReceivedMessage");

                    b.Navigation("SentMessage");

                    b.Navigation("TranslatePhotos");
                });
#pragma warning restore 612, 618
        }
    }
}
