﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockMarketWebService.Models;

namespace StockMarketWebService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201112064458_adding-deactivation-functionality")]
    partial class addingdeactivationfunctionality
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockMarketWebService.DataEntities.StockCodes", b =>
                {
                    b.Property<int>("SID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("NameOfExchange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockCodeInExchange")
                        .HasColumnType("int");

                    b.HasKey("SID");

                    b.HasIndex("CompanyID");

                    b.ToTable("StockCodes");
                });

            modelBuilder.Entity("StockMarketWebService.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("BoardOfDirectors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("SectorID")
                        .HasColumnType("int");

                    b.Property<float>("TurnOver")
                        .HasColumnType("real");

                    b.Property<string>("WriteUp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.HasIndex("SectorID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("StockMarketWebService.Models.CompanyStockExchange", b =>
                {
                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<int>("StockExchangeID")
                        .HasColumnType("int");

                    b.HasKey("CompanyID", "StockExchangeID");

                    b.HasIndex("StockExchangeID");

                    b.ToTable("companyStockExchanges");
                });

            modelBuilder.Entity("StockMarketWebService.Models.IPODetails", b =>
                {
                    b.Property<int>("ipoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OpeningDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("PricePerShare")
                        .HasColumnType("real");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalAvailableShares")
                        .HasColumnType("int");

                    b.Property<string>("stockExchanges")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ipoID");

                    b.HasIndex("CompanyID");

                    b.ToTable("IPODetails");
                });

            modelBuilder.Entity("StockMarketWebService.Models.Sectors", b =>
                {
                    b.Property<int>("SectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("WriteUp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectorID");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("StockMarketWebService.Models.StockExchange", b =>
                {
                    b.Property<int>("StockExchangeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BriefWriteUp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExchangeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("StockExchangeID");

                    b.ToTable("StockExchanges");
                });

            modelBuilder.Entity("StockMarketWebService.Models.StockPrice", b =>
                {
                    b.Property<int>("SerialNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyCode")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Exchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.HasKey("SerialNumber");

                    b.HasIndex("CompanyID");

                    b.ToTable("StockPrices");
                });

            modelBuilder.Entity("StockMarketWebService.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<bool>("confirmed")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StockMarketWebService.DataEntities.StockCodes", b =>
                {
                    b.HasOne("StockMarketWebService.Models.Company", null)
                        .WithMany("stockCodes")
                        .HasForeignKey("CompanyID");
                });

            modelBuilder.Entity("StockMarketWebService.Models.Company", b =>
                {
                    b.HasOne("StockMarketWebService.Models.Sectors", "Sector")
                        .WithMany("CompaniesInThisSector")
                        .HasForeignKey("SectorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockMarketWebService.Models.CompanyStockExchange", b =>
                {
                    b.HasOne("StockMarketWebService.Models.Company", "Company")
                        .WithMany("CompaniesListed")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockMarketWebService.Models.StockExchange", "StockExchange")
                        .WithMany("CompaniesListed")
                        .HasForeignKey("StockExchangeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockMarketWebService.Models.IPODetails", b =>
                {
                    b.HasOne("StockMarketWebService.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockMarketWebService.Models.StockPrice", b =>
                {
                    b.HasOne("StockMarketWebService.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");
                });
#pragma warning restore 612, 618
        }
    }
}