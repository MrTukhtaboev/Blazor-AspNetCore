﻿// <auto-generated />
using System;
using EmployeeManagement.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211011102051_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Moliya Vazirligi"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Davlat Soliq Qo'mitasi"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "ICT o'quv markazi"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(1999, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "toxtaboyev.m@iCloud.com",
                            FirstName = "Janob",
                            Gender = 0,
                            LastName = "Panda",
                            PhotoPath = "images/muhammadkarim.jpg"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(2000, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "abduvohid_eam@gmail.com",
                            FirstName = "Abduvohid",
                            Gender = 0,
                            LastName = "Ergashev",
                            PhotoPath = "images/abduvohid.jpg"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBirth = new DateTime(1999, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "ixtiyor1977@gmail.com",
                            FirstName = "Ixtiyor",
                            Gender = 0,
                            LastName = "Baxodirov",
                            PhotoPath = "images/ixtiyor.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}