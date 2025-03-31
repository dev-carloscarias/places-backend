﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Places.Infrastructure.Data;

#nullable disable

namespace Places.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240511050125_RemoveUserIndex")]
    partial class RemoveUserIndex
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Places.Domain.Entities.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Continents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7644), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "África",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "América",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Asia",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Europa",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7739), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Oceanía",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 759, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        });
                });

            modelBuilder.Entity("Places.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContinentId")
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Iso2")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("char(2)");

                    b.Property<string>("Iso3")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("char(3)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Places.Domain.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rate")
                        .HasMaxLength(18)
                        .HasPrecision(2)
                        .HasColumnType("numeric(18,2)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Places.Domain.Entities.Label", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("LabelCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabelValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScreenId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScreenId");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("Places.Domain.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("Places.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Super Administrator",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6000), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6002), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Regular User",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6005), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Administrator",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 760, DateTimeKind.Unspecified).AddTicks(6006), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        });
                });

            modelBuilder.Entity("Places.Domain.Entities.Screen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("ScreenCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Screens");
                });

            modelBuilder.Entity("Places.Domain.Entities.Translate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<int?>("LabelId")
                        .HasColumnType("int");

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("char");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int?>("MessageId")
                        .HasColumnType("int");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("LabelId");

                    b.HasIndex(new[] { "CommentId", "LanguageCode" }, "IX_Translate_Comment_Language");

                    b.HasIndex(new[] { "CurrencyId", "LanguageCode" }, "IX_Translate_Currency_Language");

                    b.HasIndex(new[] { "LanguageId", "LanguageCode" }, "IX_Translate_Language_Language");

                    b.HasIndex(new[] { "MessageId", "LanguageCode" }, "IX_Translate_Message_Language");

                    b.ToTable("Translates");
                });

            modelBuilder.Entity("Places.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("EmailCodeValidation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("HasEmailValidated")
                        .HasColumnType("bit");

                    b.Property<bool>("HasProperties")
                        .HasColumnType("bit");

                    b.Property<bool>("HasTelephoneValidated")
                        .HasColumnType("bit");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("MustChangePassword")
                        .HasColumnType("bit");

                    b.Property<string>("PlatformId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("RegistrationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneCodeValidation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Places.Domain.Entities.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Email",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5709), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5714), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Facebook",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5716), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Google",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5717), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5719), new TimeSpan(0, -6, 0, 0, 0)),
                            CreatedBy = 0,
                            Name = "Apple",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 5, 10, 23, 1, 24, 761, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, -6, 0, 0, 0)),
                            UpdatedBy = 0
                        });
                });

            modelBuilder.Entity("Places.Domain.Entities.Country", b =>
                {
                    b.HasOne("Places.Domain.Entities.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId");

                    b.HasOne("Places.Domain.Entities.Currency", "Currency")
                        .WithMany("Countries")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Continent");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("Places.Domain.Entities.Label", b =>
                {
                    b.HasOne("Places.Domain.Entities.Screen", "Screen")
                        .WithMany("Labels")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("Places.Domain.Entities.Translate", b =>
                {
                    b.HasOne("Places.Domain.Entities.Country", "Country")
                        .WithMany("Translates")
                        .HasForeignKey("CountryId");

                    b.HasOne("Places.Domain.Entities.Currency", "Currency")
                        .WithMany("Translates")
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Places.Domain.Entities.Label", "Label")
                        .WithMany()
                        .HasForeignKey("LabelId");

                    b.HasOne("Places.Domain.Entities.Language", "Language")
                        .WithMany("Translates")
                        .HasForeignKey("LanguageId");

                    b.Navigation("Country");

                    b.Navigation("Currency");

                    b.Navigation("Label");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Places.Domain.Entities.User", b =>
                {
                    b.HasOne("Places.Domain.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Places.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Places.Domain.Entities.UserType", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Role");

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("Places.Domain.Entities.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Places.Domain.Entities.Country", b =>
                {
                    b.Navigation("Translates");
                });

            modelBuilder.Entity("Places.Domain.Entities.Currency", b =>
                {
                    b.Navigation("Countries");

                    b.Navigation("Translates");
                });

            modelBuilder.Entity("Places.Domain.Entities.Language", b =>
                {
                    b.Navigation("Translates");
                });

            modelBuilder.Entity("Places.Domain.Entities.Screen", b =>
                {
                    b.Navigation("Labels");
                });
#pragma warning restore 612, 618
        }
    }
}
