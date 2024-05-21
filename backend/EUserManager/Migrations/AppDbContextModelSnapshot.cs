﻿// <auto-generated />
using System;
using EUserManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EUserManager.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EUserManager.Data.EntityUser+User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2603),
                            Email = "user1@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2615),
                            Username = "User1"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2619),
                            Email = "user2@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2620),
                            Username = "User2"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2622),
                            Email = "user3@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2623),
                            Username = "User3"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2626),
                            Email = "user4@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2626),
                            Username = "User4"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2628),
                            Email = "user5@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2629),
                            Username = "User5"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2631),
                            Email = "user6@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2631),
                            Username = "User6"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2633),
                            Email = "user7@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2634),
                            Username = "User7"
                        },
                        new
                        {
                            Id = 8,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2636),
                            Email = "user8@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2637),
                            Username = "User8"
                        },
                        new
                        {
                            Id = 9,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2639),
                            Email = "user9@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2639),
                            Username = "User9"
                        },
                        new
                        {
                            Id = 10,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2643),
                            Email = "user10@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2644),
                            Username = "User10"
                        },
                        new
                        {
                            Id = 11,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2646),
                            Email = "user11@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2647),
                            Username = "User11"
                        },
                        new
                        {
                            Id = 12,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2649),
                            Email = "user12@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2649),
                            Username = "User12"
                        },
                        new
                        {
                            Id = 13,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2651),
                            Email = "user13@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2652),
                            Username = "User13"
                        },
                        new
                        {
                            Id = 14,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2654),
                            Email = "user14@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2655),
                            Username = "User14"
                        },
                        new
                        {
                            Id = 15,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2657),
                            Email = "user15@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2658),
                            Username = "User15"
                        },
                        new
                        {
                            Id = 16,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2698),
                            Email = "user16@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2698),
                            Username = "User16"
                        },
                        new
                        {
                            Id = 17,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2701),
                            Email = "user17@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2701),
                            Username = "User17"
                        },
                        new
                        {
                            Id = 18,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2703),
                            Email = "user18@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2704),
                            Username = "User18"
                        },
                        new
                        {
                            Id = 19,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2706),
                            Email = "user19@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2707),
                            Username = "User19"
                        },
                        new
                        {
                            Id = 20,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2709),
                            Email = "user20@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2709),
                            Username = "User20"
                        },
                        new
                        {
                            Id = 21,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2712),
                            Email = "user21@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2712),
                            Username = "User21"
                        },
                        new
                        {
                            Id = 22,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2714),
                            Email = "user22@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2715),
                            Username = "User22"
                        },
                        new
                        {
                            Id = 23,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2717),
                            Email = "user23@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2718),
                            Username = "User23"
                        },
                        new
                        {
                            Id = 24,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2720),
                            Email = "user24@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2720),
                            Username = "User24"
                        },
                        new
                        {
                            Id = 25,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2722),
                            Email = "user25@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2723),
                            Username = "User25"
                        },
                        new
                        {
                            Id = 26,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2725),
                            Email = "user26@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2726),
                            Username = "User26"
                        },
                        new
                        {
                            Id = 27,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2728),
                            Email = "user27@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2728),
                            Username = "User27"
                        },
                        new
                        {
                            Id = 28,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2730),
                            Email = "user28@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2731),
                            Username = "User28"
                        },
                        new
                        {
                            Id = 29,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2733),
                            Email = "user29@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2734),
                            Username = "User29"
                        },
                        new
                        {
                            Id = 30,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2736),
                            Email = "user30@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2736),
                            Username = "User30"
                        },
                        new
                        {
                            Id = 31,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2739),
                            Email = "user31@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2739),
                            Username = "User31"
                        },
                        new
                        {
                            Id = 32,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2741),
                            Email = "user32@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2742),
                            Username = "User32"
                        },
                        new
                        {
                            Id = 33,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2744),
                            Email = "user33@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2744),
                            Username = "User33"
                        },
                        new
                        {
                            Id = 34,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2747),
                            Email = "user34@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2747),
                            Username = "User34"
                        },
                        new
                        {
                            Id = 35,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2749),
                            Email = "user35@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2750),
                            Username = "User35"
                        },
                        new
                        {
                            Id = 36,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2752),
                            Email = "user36@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2752),
                            Username = "User36"
                        },
                        new
                        {
                            Id = 37,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2755),
                            Email = "user37@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2755),
                            Username = "User37"
                        },
                        new
                        {
                            Id = 38,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2757),
                            Email = "user38@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2758),
                            Username = "User38"
                        },
                        new
                        {
                            Id = 39,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2760),
                            Email = "user39@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2761),
                            Username = "User39"
                        },
                        new
                        {
                            Id = 40,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2763),
                            Email = "user40@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2763),
                            Username = "User40"
                        },
                        new
                        {
                            Id = 41,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2765),
                            Email = "user41@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2766),
                            Username = "User41"
                        },
                        new
                        {
                            Id = 42,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2768),
                            Email = "user42@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2769),
                            Username = "User42"
                        },
                        new
                        {
                            Id = 43,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2771),
                            Email = "user43@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2771),
                            Username = "User43"
                        },
                        new
                        {
                            Id = 44,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2773),
                            Email = "user44@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2774),
                            Username = "User44"
                        },
                        new
                        {
                            Id = 45,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2776),
                            Email = "user45@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2777),
                            Username = "User45"
                        },
                        new
                        {
                            Id = 46,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2779),
                            Email = "user46@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2779),
                            Username = "User46"
                        },
                        new
                        {
                            Id = 47,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2781),
                            Email = "user47@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2782),
                            Username = "User47"
                        },
                        new
                        {
                            Id = 48,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2784),
                            Email = "user48@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2785),
                            Username = "User48"
                        },
                        new
                        {
                            Id = 49,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2787),
                            Email = "user49@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2787),
                            Username = "User49"
                        },
                        new
                        {
                            Id = 50,
                            CreateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2790),
                            Email = "user50@example.com",
                            Password = "123456",
                            UpdateDate = new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2790),
                            Username = "User50"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
