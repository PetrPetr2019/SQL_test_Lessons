﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeopleStaff;

namespace PeopleStaff.Migrations
{
    [DbContext(typeof(AppStafContext))]
    [Migration("20200902190929_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PeopleStaff.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cnum")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<string>("sity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("snum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("customerses");
                });

            modelBuilder.Entity("PeopleStaff.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("amt")
                        .HasColumnType("float");

                    b.Property<int>("cnum")
                        .HasColumnType("int");

                    b.Property<DateTime>("odate")
                        .HasColumnType("datetime2");

                    b.Property<int>("onum")
                        .HasColumnType("int");

                    b.Property<int>("snum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("orderses");
                });

            modelBuilder.Entity("PeopleStaff.Salespeople", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("comm")
                        .HasColumnType("float");

                    b.Property<string>("sity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("snum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("salespeoples");
                });
#pragma warning restore 612, 618
        }
    }
}
