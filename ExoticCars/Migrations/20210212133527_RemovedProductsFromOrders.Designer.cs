﻿// <auto-generated />
using System;
using ExoticCars.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExoticCars.Migrations
{
    [DbContext(typeof(ExoticCarContext))]
    [Migration("20210212133527_RemovedProductsFromOrders")]
    partial class RemovedProductsFromOrders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExoticCars.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Address = "41 Phylli Street, Mount Pleasant",
                            City = "Port Elizabeth",
                            FirstName = "Carson",
                            LastName = "Alexander",
                            Phone = "0825548974",
                            PostalCode = "6010"
                        },
                        new
                        {
                            CustomerID = 2,
                            Address = "23 Meerhof Street, Chaleston Hill",
                            City = "Paarl",
                            FirstName = "Meredith",
                            LastName = "Alonso",
                            Phone = "0828948974",
                            PostalCode = "7646"
                        },
                        new
                        {
                            CustomerID = 3,
                            Address = "89 School Street, New Orleans",
                            City = "Paarl",
                            FirstName = "Arturo",
                            LastName = "Anand",
                            Phone = "0835548974",
                            PostalCode = "7623"
                        },
                        new
                        {
                            CustomerID = 4,
                            Address = "5 Blue Nountain Avenue, Calremont",
                            City = "Cape Town",
                            FirstName = "Gytis",
                            LastName = "Barzdukas",
                            Phone = "0845548974",
                            PostalCode = "8001"
                        },
                        new
                        {
                            CustomerID = 5,
                            Address = "3rd Avenue, Boston",
                            City = "Johannesburg",
                            FirstName = "Yan",
                            LastName = "Li",
                            Phone = "0825548800",
                            PostalCode = "7000"
                        },
                        new
                        {
                            CustomerID = 6,
                            Address = "74 Macon Street, Lorraine",
                            City = "Port Elizabeth",
                            FirstName = "Peggy",
                            LastName = "Justice",
                            Phone = "0822348974",
                            PostalCode = "6010"
                        },
                        new
                        {
                            CustomerID = 7,
                            Address = "54 Main Street, Klein Drakenstein",
                            City = "East London",
                            FirstName = "Laura",
                            LastName = "Norman",
                            Phone = "0815548974",
                            PostalCode = "3558"
                        },
                        new
                        {
                            CustomerID = 8,
                            Address = "354 Piccadilly Street, Seaview",
                            City = "Durban",
                            FirstName = "Nino",
                            LastName = "Olivetto",
                            Phone = "0824848974",
                            PostalCode = "4000"
                        },
                        new
                        {
                            CustomerID = 9,
                            Address = "48 Butcher Road, Sydenham",
                            City = "Durban",
                            FirstName = "Elton",
                            LastName = "Daries",
                            Phone = "0825333974",
                            PostalCode = "6010"
                        },
                        new
                        {
                            CustomerID = 10,
                            Address = "454 Moon Street,Lake Virginia",
                            City = "Prtoria",
                            FirstName = "Brian",
                            LastName = "Watson",
                            Phone = "0825585274",
                            PostalCode = "8954"
                        });
                });

            modelBuilder.Entity("ExoticCars.Models.Extra", b =>
                {
                    b.Property<int>("ExtraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExtraName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("ExtraPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(50);

                    b.HasKey("ExtraID");

                    b.ToTable("Extras");
                });

            modelBuilder.Entity("ExoticCars.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            Comments = "Order on hold for customer. Credit check in progress",
                            CustomerID = 1,
                            OrderDate = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2
                        },
                        new
                        {
                            OrderID = 2,
                            Comments = "Customer wating for optional extra",
                            CustomerID = 3,
                            OrderDate = new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            OrderID = 3,
                            Comments = "Car shipped from manufaturer",
                            CustomerID = 4,
                            OrderDate = new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 4
                        },
                        new
                        {
                            OrderID = 4,
                            Comments = "Order on hold for customer. Credit check in progress",
                            CustomerID = 6,
                            OrderDate = new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2
                        },
                        new
                        {
                            OrderID = 5,
                            Comments = "Car shipped from manufaturer",
                            CustomerID = 7,
                            OrderDate = new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            OrderID = 6,
                            Comments = "Car shipped from manufaturer",
                            CustomerID = 9,
                            OrderDate = new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        });
                });

            modelBuilder.Entity("ExoticCars.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExtraID")
                        .HasColumnType("int");

                    b.Property<double>("OptionalExtra")
                        .HasColumnType("float");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderProductID");

                    b.HasIndex("ExtraID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("ExoticCars.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CostPrice")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("EngineNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("SellingPrice")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CostPrice = 10000000,
                            EngineNo = "L22AM03790",
                            Model = "Defender 90",
                            Name = "Land Rover",
                            SellingPrice = 15000000,
                            Year = "2018"
                        },
                        new
                        {
                            ProductID = 2,
                            CostPrice = 25000000,
                            EngineNo = "M22AM08524",
                            Model = "A6GCS/53",
                            Name = "Maserati",
                            SellingPrice = 3500000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 3,
                            CostPrice = 27000000,
                            EngineNo = "C22AM03737",
                            Model = "XT5",
                            Name = "Cadillac",
                            SellingPrice = 3000000,
                            Year = "2019"
                        },
                        new
                        {
                            ProductID = 4,
                            CostPrice = 9000000,
                            EngineNo = "J22AM07894",
                            Model = "F-Type SVR",
                            Name = "Jaguar",
                            SellingPrice = 1000000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 5,
                            CostPrice = 15000000,
                            EngineNo = "B22AM00247",
                            Model = "BMW E36 M3",
                            Name = "BMW",
                            SellingPrice = 2000000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 6,
                            CostPrice = 28000000,
                            EngineNo = "P22AM08761",
                            Model = "911 Carrera RS 3.0",
                            Name = "Porsche",
                            SellingPrice = 3500000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 7,
                            CostPrice = 35000000,
                            EngineNo = "F22AM08520",
                            Model = "812 GTS",
                            Name = "Ferarri",
                            SellingPrice = 3800000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 8,
                            CostPrice = 15000000,
                            EngineNo = "A22AM07419",
                            Model = "Audi Q8",
                            Name = "Audi",
                            SellingPrice = 2000000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 9,
                            CostPrice = 12000000,
                            EngineNo = "AL2AM08719",
                            Model = "Giulia Quadrifoglio",
                            Name = "Alfa Romeo",
                            SellingPrice = 1500000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 10,
                            CostPrice = 22000000,
                            EngineNo = "MB2AM07531",
                            Model = "AMG GT 63",
                            Name = "Mercedez-Benz",
                            SellingPrice = 2500000,
                            Year = "2020"
                        });
                });

            modelBuilder.Entity("ExoticCars.Models.Order", b =>
                {
                    b.HasOne("ExoticCars.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExoticCars.Models.OrderProduct", b =>
                {
                    b.HasOne("ExoticCars.Models.Extra", "Extra")
                        .WithMany()
                        .HasForeignKey("ExtraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExoticCars.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExoticCars.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
