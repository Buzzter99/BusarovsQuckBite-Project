﻿// <auto-generated />
using System;
using BusarovsQuckBite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusarovsQuckBite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240307212628_testScheme")]
    partial class testScheme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("TransactionDateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("Who");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("TransactionDateAndTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            ConcurrencyStamp = "fdc0782d-123c-4e3b-b351-11df6dbcbcaf",
                            Name = "Admin",
                            NormalizedName = "ADMIN",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2701)
                        },
                        new
                        {
                            Id = "fa175b24-e5a7-41ab-8237-94734f2b5408",
                            ConcurrencyStamp = "1dfe148c-5d11-432b-827c-6e76c2ebc52f",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2711)
                        },
                        new
                        {
                            Id = "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                            ConcurrencyStamp = "4e8e9883-48b4-475c-92c5-456476fce2ea",
                            Name = "Delivery Driver",
                            NormalizedName = "DELIVERY DRIVER",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2718)
                        },
                        new
                        {
                            Id = "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                            ConcurrencyStamp = "96b728a3-1dea-436b-8915-34c4e8063c28",
                            Name = "Cooking Staff",
                            NormalizedName = "COOKING STAFF",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2722)
                        });
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9f1a47bb-b51a-4547-a713-60edfa13eaee",
                            Email = "CfDJ8HeH4f54VCZHnfY0KvPjmDhMMBcNwki7Gr45dKMMS3DZw-4DfOcQ3N0gUxFjQfLrAtpudMHdkuAKTPIuyb-TOAD_mVx9PqjLg1Rd1lOT-nigm5S-SL6o6ZzqBdslOF2-IUVg2xgr01jiVtnbMNZn6Xg",
                            EmailConfirmed = true,
                            FirstName = "",
                            IsActive = true,
                            LastName = "",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEK02ybmaqeMUHSCJfeCI3lQAaMcmElHtItsHthSWZxWOE6oMKlg2GkwgxfvYeW7dQg==",
                            PhoneNumber = "CfDJ8HeH4f54VCZHnfY0KvPjmDijMmM4PDxZTqnc14Bakn2OkZu7OUU9TuUyJQaWQuQgK7EmwK5KAFVMYLmPr4S55n1kN3Hah_G4kYw61faG3Xvg8pD_HntZVrYcU9sAzYExUA",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "ab3281d7-6071-4d01-ad3b-00957d6ea838",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(2100),
                            TwoFactorEnabled = false,
                            UserName = "CfDJ8HeH4f54VCZHnfY0KvPjmDiq1Ra4X4GdiF3C23ddCTcdL-wp5bwuq9w5YRfsEqwPsq9rWtrmthuh0ERH3YCSgr95FZkZK_MjhRxhA06slug-kS7ijHhQQCg6sBMKfMXyZw"
                        });
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("TransactionDateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("Who");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.CartProduct", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("TransactionDateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("Who");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Snacks",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3492),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Burgers",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3503),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Drinks",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3505),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Pizzas",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3507),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Pasta",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3508),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Sandwiches",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3511),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "Desserts",
                            TransactionDateAndTime = new DateTime(2024, 3, 7, 23, 26, 28, 53, DateTimeKind.Local).AddTicks(3513),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        });
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(18, 5)
                        .HasColumnType("decimal(18,5)");

                    b.Property<DateTime>("TransactionDateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("Who");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Who")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Who");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Address", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Cart", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", "User")
                        .WithMany("Carts")
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.CartProduct", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.Cart", "Cart")
                        .WithMany("Products")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusarovsQuckBite.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Category", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", "User")
                        .WithMany("Categories")
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Order", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Product", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", "User")
                        .WithMany("Products")
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Carts");

                    b.Navigation("Categories");

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Cart", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
