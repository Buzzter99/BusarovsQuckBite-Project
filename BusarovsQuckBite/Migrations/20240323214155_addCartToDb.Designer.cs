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
    [Migration("20240323214155_addCartToDb")]
    partial class addCartToDb
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
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

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
                            ConcurrencyStamp = "cc6c3972-614c-4c39-bbc5-64804a32740d",
                            Name = "Admin",
                            NormalizedName = "ADMIN",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7350)
                        },
                        new
                        {
                            Id = "fa175b24-e5a7-41ab-8237-94734f2b5408",
                            ConcurrencyStamp = "b6ff975d-47e4-4cdc-91d5-2a5fcdedee67",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7356)
                        },
                        new
                        {
                            Id = "22ccb117-1c50-47a5-bc43-1d9a84879e10",
                            ConcurrencyStamp = "cc97fc37-ab14-4c49-bea9-25cb0b702aad",
                            Name = "Delivery Driver",
                            NormalizedName = "DELIVERY DRIVER",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7361)
                        },
                        new
                        {
                            Id = "a1a8637e-6e83-4ee9-adef-09cd724473a7",
                            ConcurrencyStamp = "2be50fc1-697c-4b1a-b7cb-889c6f4e835b",
                            Name = "Cooking Staff",
                            NormalizedName = "COOKING STAFF",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7366)
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
                        .IsRequired()
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
                            ConcurrencyStamp = "d781faa2-be88-41b1-906f-ca0f074ff6f6",
                            Email = "brandabg1@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "",
                            IsActive = true,
                            LastName = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "BRANDABG1@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEAGbif0FWwc0XJbQJ4FJGB0EyWpra20Iih/R9usdP+k9SXComDgv+EqdEEtngBQ3IQ==",
                            PhoneNumber = "0896722926",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "0c7dcb56-a249-4fdc-8b09-c334ec03dc54",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(7175),
                            TwoFactorEnabled = false,
                            UserName = "Admin"
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

                    b.ToTable("Carts");
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
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8191),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Burgers",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8201),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Drinks",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8203),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Pizzas",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8205),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Pasta",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8206),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Sandwiches",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8209),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "Desserts",
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(8210),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        });
                });

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Img", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullPath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RelativePath")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Img");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullPath = "C:/Users/GRIGS/source/repos/BusarovsQuckBite/BusarovsQuckBite/wwwroot/Images/download.jpg",
                            Name = "download.jpg",
                            RelativePath = "~/Images/"
                        },
                        new
                        {
                            Id = 2,
                            FullPath = "C:/Users/GRIGS/source/repos/BusarovsQuckBite/BusarovsQuckBite/wwwroot/Images/tuborg.jpg",
                            Name = "tuborg.jpg",
                            RelativePath = "~/Images/"
                        },
                        new
                        {
                            Id = 3,
                            FullPath = "C:/Users/GRIGS/source/repos/BusarovsQuckBite/BusarovsQuckBite/wwwroot/Images/hamburger-baked-in-oven.jpg",
                            Name = "hamburger-baked-in-oven.jpg",
                            RelativePath = "~/Images/"
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

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

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

                    b.HasIndex("ImageId");

                    b.HasIndex("Who");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 4,
                            Description = "Pizza",
                            ImageId = 1,
                            IsDeleted = false,
                            Name = "Pepperoni Pizza",
                            Price = 15.00m,
                            Quantity = 10,
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(9090),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Description = "Beer",
                            ImageId = 2,
                            IsDeleted = false,
                            Name = "Tuborg Beer",
                            Price = 5.00m,
                            Quantity = 50,
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(9100),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Burger",
                            ImageId = 3,
                            IsDeleted = false,
                            Name = "Hamburger",
                            Price = 8.50m,
                            Quantity = 15,
                            TransactionDateAndTime = new DateTime(2024, 3, 23, 23, 41, 55, 415, DateTimeKind.Local).AddTicks(9102),
                            Who = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasOne("BusarovsQuckBite.Data.Models.Img", "Img")
                        .WithMany("Products")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusarovsQuckBite.Data.Models.ApplicationUser", "User")
                        .WithMany("Products")
                        .HasForeignKey("Who")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Img");

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

            modelBuilder.Entity("BusarovsQuckBite.Data.Models.Img", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}