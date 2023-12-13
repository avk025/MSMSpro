﻿// <auto-generated />
using MSMSwebapipro.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MSMSwebapipro.Migrations
{
    [DbContext(typeof(ProjectDBcontext))]
    [Migration("20230811050535_newmsmsprojectcreation")]
    partial class newmsmsprojectcreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MSMSwebapipro.Models.Department", b =>
                {
                    b.Property<int>("DeptNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Dname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("locatin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptNo");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("MSMSwebapipro.Models.Employee", b =>
                {
                    b.Property<int>("Empid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("DeptNo")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Empid");

                    b.HasIndex("DeptNo");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("MSMSwebapipro.Models.Employee", b =>
                {
                    b.HasOne("MSMSwebapipro.Models.Department", "Department")
                        .WithMany("employees")
                        .HasForeignKey("DeptNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MSMSwebapipro.Models.Department", b =>
                {
                    b.Navigation("employees");
                });
#pragma warning restore 612, 618
        }
    }
}
