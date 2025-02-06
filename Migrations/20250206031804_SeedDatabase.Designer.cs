﻿// <auto-generated />
using ICMPC_Test.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ICMPC_Test.Migrations
{
    [DbContext(typeof(UserProductsContext))]
    [Migration("20250206031804_SeedDatabase")]
    partial class SeedDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ICMPC_Test.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Description for product 1",
                            Price = 10.0,
                            ProductName = "Product 1",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Description for product 2",
                            Price = 20.0,
                            ProductName = "Product 2",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Description for product 3",
                            Price = 30.0,
                            ProductName = "Product 3",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Description for product 4",
                            Price = 40.0,
                            ProductName = "Product 4",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "Description for product 5",
                            Price = 50.0,
                            ProductName = "Product 5",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 6,
                            Description = "Description for product 6",
                            Price = 60.0,
                            ProductName = "Product 6",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 7,
                            Description = "Description for product 7",
                            Price = 70.0,
                            ProductName = "Product 7",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 8,
                            Description = "Description for product 8",
                            Price = 80.0,
                            ProductName = "Product 8",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 9,
                            Description = "Description for product 9",
                            Price = 90.0,
                            ProductName = "Product 9",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 10,
                            Description = "Description for product 10",
                            Price = 100.0,
                            ProductName = "Product 10",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 11,
                            Description = "Description for product 11",
                            Price = 110.0,
                            ProductName = "Product 11",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 12,
                            Description = "Description for product 12",
                            Price = 120.0,
                            ProductName = "Product 12",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 13,
                            Description = "Description for product 13",
                            Price = 130.0,
                            ProductName = "Product 13",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 14,
                            Description = "Description for product 14",
                            Price = 140.0,
                            ProductName = "Product 14",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 15,
                            Description = "Description for product 15",
                            Price = 150.0,
                            ProductName = "Product 15",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 16,
                            Description = "Description for product 16",
                            Price = 160.0,
                            ProductName = "Product 16",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 17,
                            Description = "Description for product 17",
                            Price = 170.0,
                            ProductName = "Product 17",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 18,
                            Description = "Description for product 18",
                            Price = 180.0,
                            ProductName = "Product 18",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 19,
                            Description = "Description for product 19",
                            Price = 190.0,
                            ProductName = "Product 19",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 20,
                            Description = "Description for product 20",
                            Price = 200.0,
                            ProductName = "Product 20",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 21,
                            Description = "Description for product 21",
                            Price = 210.0,
                            ProductName = "Product 21",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 22,
                            Description = "Description for product 22",
                            Price = 220.0,
                            ProductName = "Product 22",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 23,
                            Description = "Description for product 23",
                            Price = 230.0,
                            ProductName = "Product 23",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 24,
                            Description = "Description for product 24",
                            Price = 240.0,
                            ProductName = "Product 24",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 25,
                            Description = "Description for product 25",
                            Price = 250.0,
                            ProductName = "Product 25",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 26,
                            Description = "Description for product 26",
                            Price = 260.0,
                            ProductName = "Product 26",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 27,
                            Description = "Description for product 27",
                            Price = 270.0,
                            ProductName = "Product 27",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 28,
                            Description = "Description for product 28",
                            Price = 280.0,
                            ProductName = "Product 28",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 29,
                            Description = "Description for product 29",
                            Price = 290.0,
                            ProductName = "Product 29",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 30,
                            Description = "Description for product 30",
                            Price = 300.0,
                            ProductName = "Product 30",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("ICMPC_Test.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "admin@example.com",
                            PasswordHash = "$2a$11$7Qy5wIxiPIuokfKhFwKAMOIRY8N5p9N40XNDX4wLopzAdprdiBeRm",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("ICMPC_Test.Models.Product", b =>
                {
                    b.HasOne("ICMPC_Test.Models.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ICMPC_Test.Models.User", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
