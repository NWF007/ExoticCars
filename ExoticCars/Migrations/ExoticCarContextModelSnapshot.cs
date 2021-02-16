﻿// <auto-generated />
using System;
using ExoticCars.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExoticCars.Migrations
{
    [DbContext(typeof(ExoticCarContext))]
    partial class ExoticCarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("ExtraPrice")
                        .HasColumnType("int");

                    b.HasKey("ExtraID");

                    b.ToTable("Extras");

                    b.HasData(
                        new
                        {
                            ExtraID = 1,
                            ExtraName = "Sunroof",
                            ExtraPrice = 5000
                        },
                        new
                        {
                            ExtraID = 2,
                            ExtraName = "Sport exhaust",
                            ExtraPrice = 15000
                        },
                        new
                        {
                            ExtraID = 3,
                            ExtraName = "22 inch Wheels",
                            ExtraPrice = 20000
                        },
                        new
                        {
                            ExtraID = 4,
                            ExtraName = "Matte Black paint",
                            ExtraPrice = 7000
                        },
                        new
                        {
                            ExtraID = 5,
                            ExtraName = "Bang & Olufsen sound system",
                            ExtraPrice = 12000
                        },
                        new
                        {
                            ExtraID = 6,
                            ExtraName = "Carbon Ceramic Brakes",
                            ExtraPrice = 22000
                        });
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

                    b.Property<int>("TotalAmount")
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
                            Status = 2,
                            TotalAmount = 960000
                        },
                        new
                        {
                            OrderID = 2,
                            Comments = "Customer wating for optional extra",
                            CustomerID = 3,
                            OrderDate = new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TotalAmount = 545000
                        },
                        new
                        {
                            OrderID = 3,
                            Comments = "Car shipped from manufaturer",
                            CustomerID = 4,
                            OrderDate = new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 4,
                            TotalAmount = 270000
                        },
                        new
                        {
                            OrderID = 4,
                            Comments = "Order on hold for customer. Credit check in progress",
                            CustomerID = 6,
                            OrderDate = new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2,
                            TotalAmount = 157000
                        },
                        new
                        {
                            OrderID = 5,
                            Comments = "Car shipped from manufaturer",
                            CustomerID = 7,
                            OrderDate = new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TotalAmount = 754000
                        },
                        new
                        {
                            OrderID = 6,
                            Comments = "Car shipped from manufaturer",
                            CustomerID = 9,
                            OrderDate = new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TotalAmount = 377000
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

                    b.Property<double>("ExtraQuantity")
                        .HasColumnType("float");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.HasKey("OrderProductID");

                    b.HasIndex("ExtraID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            OrderProductID = 1,
                            ExtraID = 2,
                            ExtraQuantity = 1.0,
                            OrderID = 1,
                            Price = 165000.0,
                            ProductID = 1,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 2,
                            ExtraID = 2,
                            ExtraQuantity = 1.0,
                            OrderID = 1,
                            Price = 365000.0,
                            ProductID = 2,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 3,
                            ExtraID = 2,
                            ExtraQuantity = 1.0,
                            OrderID = 1,
                            Price = 315000.0,
                            ProductID = 3,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 4,
                            ExtraID = 2,
                            ExtraQuantity = 1.0,
                            OrderID = 1,
                            Price = 115000.0,
                            ProductID = 4,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 5,
                            ExtraID = 2,
                            ExtraQuantity = 1.0,
                            OrderID = 2,
                            Price = 165000.0,
                            ProductID = 1,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 6,
                            ExtraID = 2,
                            ExtraQuantity = 1.0,
                            OrderID = 2,
                            Price = 215000.0,
                            ProductID = 8,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 7,
                            ExtraID = 2,
                            ExtraQuantity = 1.0,
                            OrderID = 2,
                            Price = 165000.0,
                            ProductID = 9,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 8,
                            ExtraID = 3,
                            ExtraQuantity = 1.0,
                            OrderID = 3,
                            Price = 270000.0,
                            ProductID = 10,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 9,
                            ExtraID = 4,
                            ExtraQuantity = 1.0,
                            OrderID = 4,
                            Price = 157000.0,
                            ProductID = 1,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 10,
                            ExtraID = 5,
                            ExtraQuantity = 1.0,
                            OrderID = 5,
                            Price = 362000.0,
                            ProductID = 6,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 11,
                            ExtraID = 5,
                            ExtraQuantity = 1.0,
                            OrderID = 5,
                            Price = 392000.0,
                            ProductID = 7,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 12,
                            ExtraID = 6,
                            ExtraQuantity = 1.0,
                            OrderID = 6,
                            Price = 222000.0,
                            ProductID = 5,
                            ProductQuantity = 1
                        },
                        new
                        {
                            OrderProductID = 13,
                            ExtraID = 6,
                            ExtraQuantity = 1.0,
                            OrderID = 6,
                            Price = 155000.0,
                            ProductID = 8,
                            ProductQuantity = 1
                        });
                });

            modelBuilder.Entity("ExoticCars.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CostPrice")
                        .HasColumnType("int");

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
                        .HasColumnType("int");

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
                            CostPrice = 100000,
                            EngineNo = "L22AM03790",
                            Model = "Defender 90",
                            Name = "Land Rover",
                            SellingPrice = 150000,
                            Year = "2018"
                        },
                        new
                        {
                            ProductID = 2,
                            CostPrice = 250000,
                            EngineNo = "M22AM08524",
                            Model = "A6GCS/53",
                            Name = "Maserati",
                            SellingPrice = 350000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 3,
                            CostPrice = 270000,
                            EngineNo = "C22AM03737",
                            Model = "XT5",
                            Name = "Cadillac",
                            SellingPrice = 300000,
                            Year = "2019"
                        },
                        new
                        {
                            ProductID = 4,
                            CostPrice = 90000,
                            EngineNo = "J22AM07894",
                            Model = "F-Type SVR",
                            Name = "Jaguar",
                            SellingPrice = 100000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 5,
                            CostPrice = 150000,
                            EngineNo = "B22AM00247",
                            Model = "BMW E36 M3",
                            Name = "BMW",
                            SellingPrice = 200000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 6,
                            CostPrice = 280000,
                            EngineNo = "P22AM08761",
                            Model = "911 Carrera RS 3.0",
                            Name = "Porsche",
                            SellingPrice = 350000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 7,
                            CostPrice = 350000,
                            EngineNo = "F22AM08520",
                            Model = "812 GTS",
                            Name = "Ferarri",
                            SellingPrice = 380000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 8,
                            CostPrice = 150000,
                            EngineNo = "A22AM07419",
                            Model = "Audi Q8",
                            Name = "Audi",
                            SellingPrice = 200000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 9,
                            CostPrice = 120000,
                            EngineNo = "AL2AM08719",
                            Model = "Giulia Quadrifoglio",
                            Name = "Alfa Romeo",
                            SellingPrice = 150000,
                            Year = "2020"
                        },
                        new
                        {
                            ProductID = 10,
                            CostPrice = 220000,
                            EngineNo = "MB2AM07531",
                            Model = "AMG GT 63",
                            Name = "Mercedez-Benz",
                            SellingPrice = 250000,
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
                        .WithMany("OrderProducts")
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
