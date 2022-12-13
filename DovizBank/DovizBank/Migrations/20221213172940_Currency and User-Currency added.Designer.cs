﻿// <auto-generated />
using System;
using DovizBank.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DovizBank.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221213172940_Currency and User-Currency added")]
    partial class CurrencyandUserCurrencyadded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DovizBank.Entity.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Purchase")
                        .HasColumnType("float");

                    b.Property<double>("Sale")
                        .HasColumnType("float");

                    b.Property<int?>("UserCurrencyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserCurrencyId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("DovizBank.Entity.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserCurrencyId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("UserCurrencyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DovizBank.Entity.UserCurrency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserCurrencies");
                });

            modelBuilder.Entity("DovizBank.Entity.Currency", b =>
                {
                    b.HasOne("DovizBank.Entity.UserCurrency", null)
                        .WithMany("Currency")
                        .HasForeignKey("UserCurrencyId");
                });

            modelBuilder.Entity("DovizBank.Entity.User", b =>
                {
                    b.HasOne("DovizBank.Entity.UserCurrency", null)
                        .WithMany("User")
                        .HasForeignKey("UserCurrencyId");
                });

            modelBuilder.Entity("DovizBank.Entity.UserCurrency", b =>
                {
                    b.Navigation("Currency");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}