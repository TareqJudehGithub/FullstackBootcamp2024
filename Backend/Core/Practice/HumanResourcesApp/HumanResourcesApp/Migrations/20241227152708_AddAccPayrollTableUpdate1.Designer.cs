﻿// <auto-generated />
using System;
using HumanResourcesApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HumanResourcesApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241227152708_AddAccPayrollTableUpdate1")]
    partial class AddAccPayrollTableUpdate1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HumanResourcesApp.Areas.Accounting.Models.AccPayroll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("PayrollAmount")
                        .HasColumnType("DECIMAL(18,3)");

                    b.Property<DateTime?>("TS")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.ToTable("AccPayroll", "dbo");
                });

            modelBuilder.Entity("HumanResourcesApp.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HumanResourcesApp.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("DECIMAL(18,3)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INT");

                    b.Property<string>("EmployeeEmail")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HumanResourcesApp.Models.Payroll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("DECIMAL(18,3)");

                    b.Property<decimal>("Bonus")
                        .HasColumnType("DECIMAL(18,3)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("INT");

                    b.Property<double>("Leaves")
                        .HasColumnType("FLOAT");

                    b.Property<decimal>("NetSalary")
                        .HasColumnType("DECIMAL(18,3)");

                    b.Property<DateTime>("PayrollDate")
                        .HasColumnType("DATETIME");

                    b.Property<decimal>("SocialSecurityAmount")
                        .HasColumnType("DECIMAL(18,3)");

                    b.Property<DateTime?>("TS")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Payrolls", "dbo");
                });

            modelBuilder.Entity("HumanResourcesApp.Models.Employee", b =>
                {
                    b.HasOne("HumanResourcesApp.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("HumanResourcesApp.Models.Payroll", b =>
                {
                    b.HasOne("HumanResourcesApp.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}