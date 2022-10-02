﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using awprojectdata;

#nullable disable

namespace awprojectdata.Migrations
{
    [DbContext(typeof(AwProjectDbContext))]
    partial class AwProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("awprojectmodels.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhonePrimary")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PhoneSecondary")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("StreetAddress2")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("awprojectmodels.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abbreviation = "AL",
                            Name = "Alabama"
                        },
                        new
                        {
                            Id = 2,
                            Abbreviation = "AK",
                            Name = "Alaska"
                        },
                        new
                        {
                            Id = 3,
                            Abbreviation = "AZ",
                            Name = "Arizona"
                        },
                        new
                        {
                            Id = 4,
                            Abbreviation = "AR",
                            Name = "Arkansas"
                        },
                        new
                        {
                            Id = 5,
                            Abbreviation = "CA",
                            Name = "California"
                        },
                        new
                        {
                            Id = 6,
                            Abbreviation = "CO",
                            Name = "Colorado"
                        },
                        new
                        {
                            Id = 7,
                            Abbreviation = "CT",
                            Name = "Connecticut"
                        },
                        new
                        {
                            Id = 8,
                            Abbreviation = "DE",
                            Name = "Delaware"
                        },
                        new
                        {
                            Id = 9,
                            Abbreviation = "DC",
                            Name = "District of Columbia"
                        },
                        new
                        {
                            Id = 10,
                            Abbreviation = "FL",
                            Name = "Florida"
                        },
                        new
                        {
                            Id = 11,
                            Abbreviation = "GA",
                            Name = "Georgia"
                        },
                        new
                        {
                            Id = 12,
                            Abbreviation = "HI",
                            Name = "Hawaii"
                        },
                        new
                        {
                            Id = 13,
                            Abbreviation = "ID",
                            Name = "Idaho"
                        },
                        new
                        {
                            Id = 14,
                            Abbreviation = "IL",
                            Name = "Illinois"
                        },
                        new
                        {
                            Id = 15,
                            Abbreviation = "IN",
                            Name = "Indiana"
                        },
                        new
                        {
                            Id = 16,
                            Abbreviation = "IA",
                            Name = "Iowa"
                        },
                        new
                        {
                            Id = 17,
                            Abbreviation = "KS",
                            Name = "Kansas"
                        },
                        new
                        {
                            Id = 18,
                            Abbreviation = "KY",
                            Name = "Kentucky"
                        },
                        new
                        {
                            Id = 19,
                            Abbreviation = "LA",
                            Name = "Louisiana"
                        },
                        new
                        {
                            Id = 20,
                            Abbreviation = "ME",
                            Name = "Maine"
                        },
                        new
                        {
                            Id = 21,
                            Abbreviation = "MD",
                            Name = "Maryland"
                        },
                        new
                        {
                            Id = 22,
                            Abbreviation = "MS",
                            Name = "Massachusetts"
                        },
                        new
                        {
                            Id = 23,
                            Abbreviation = "MI",
                            Name = "Michigan"
                        },
                        new
                        {
                            Id = 24,
                            Abbreviation = "MN",
                            Name = "Minnesota"
                        },
                        new
                        {
                            Id = 25,
                            Abbreviation = "MS",
                            Name = "Mississippi"
                        },
                        new
                        {
                            Id = 26,
                            Abbreviation = "MO",
                            Name = "Missouri"
                        },
                        new
                        {
                            Id = 27,
                            Abbreviation = "MT",
                            Name = "Montana"
                        },
                        new
                        {
                            Id = 28,
                            Abbreviation = "NE",
                            Name = "Nebraska"
                        },
                        new
                        {
                            Id = 29,
                            Abbreviation = "NV",
                            Name = "Nevada"
                        },
                        new
                        {
                            Id = 30,
                            Abbreviation = "NH",
                            Name = "New Hampshire"
                        },
                        new
                        {
                            Id = 31,
                            Abbreviation = "NJ",
                            Name = "New Jersey"
                        },
                        new
                        {
                            Id = 32,
                            Abbreviation = "NM",
                            Name = "New Mexico"
                        },
                        new
                        {
                            Id = 33,
                            Abbreviation = "NY",
                            Name = "New York"
                        },
                        new
                        {
                            Id = 34,
                            Abbreviation = "NC",
                            Name = "North Carolina"
                        },
                        new
                        {
                            Id = 35,
                            Abbreviation = "ND",
                            Name = "North Dakota"
                        },
                        new
                        {
                            Id = 36,
                            Abbreviation = "OH",
                            Name = "Ohio"
                        },
                        new
                        {
                            Id = 37,
                            Abbreviation = "OK",
                            Name = "Oklahoma"
                        },
                        new
                        {
                            Id = 38,
                            Abbreviation = "OR",
                            Name = "Oregon"
                        },
                        new
                        {
                            Id = 39,
                            Abbreviation = "PA",
                            Name = "Pennsylvania"
                        },
                        new
                        {
                            Id = 40,
                            Abbreviation = "RI",
                            Name = "Rhode Island"
                        },
                        new
                        {
                            Id = 41,
                            Abbreviation = "SC",
                            Name = "South Carolina"
                        },
                        new
                        {
                            Id = 42,
                            Abbreviation = "SD",
                            Name = "South Dakota"
                        },
                        new
                        {
                            Id = 43,
                            Abbreviation = "TN",
                            Name = "Tennessee"
                        },
                        new
                        {
                            Id = 44,
                            Abbreviation = "TX",
                            Name = "Texas"
                        },
                        new
                        {
                            Id = 45,
                            Abbreviation = "UT",
                            Name = "Utah"
                        },
                        new
                        {
                            Id = 46,
                            Abbreviation = "VT",
                            Name = "Vermont"
                        },
                        new
                        {
                            Id = 47,
                            Abbreviation = "VA",
                            Name = "Virginia"
                        },
                        new
                        {
                            Id = 48,
                            Abbreviation = "WA",
                            Name = "Washington"
                        },
                        new
                        {
                            Id = 49,
                            Abbreviation = "WV",
                            Name = "West Virginia"
                        },
                        new
                        {
                            Id = 50,
                            Abbreviation = "WI",
                            Name = "Wisconsin"
                        },
                        new
                        {
                            Id = 51,
                            Abbreviation = "WY",
                            Name = "Wyoming"
                        });
                });

            modelBuilder.Entity("awprojectmodels.Contact", b =>
                {
                    b.HasOne("awprojectmodels.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });
#pragma warning restore 612, 618
        }
    }
}
