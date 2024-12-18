﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechGate.Data;

#nullable disable

namespace TechGate.Infrastructure.Migrations
{
    [DbContext(typeof(TechGateDbContext))]
    [Migration("20241218123814_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("identity")
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", "identity");
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

                    b.ToTable("AspNetRoleClaims", "identity");
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
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", "identity");
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
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", "identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", "identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", "identity");
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories", "identity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Headphones"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Earbuds"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Keyboards"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mice"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Monitors"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Speakers"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Mouse Pads"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Gaming Chairs"
                        });
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders", "identity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderDate = new DateTime(2024, 12, 18, 14, 38, 13, 955, DateTimeKind.Local).AddTicks(1900),
                            OrderStatus = 0,
                            ShippingAddress = "5 Vitosha Boulevard, Sofia",
                            TotalAmount = 69.99m,
                            UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        },
                        new
                        {
                            Id = 2,
                            OrderDate = new DateTime(2024, 12, 18, 14, 8, 13, 955, DateTimeKind.Local).AddTicks(1915),
                            OrderStatus = 5,
                            ShippingAddress = "8 Alexander Nevsky Square, Sofia",
                            TotalAmount = 329.97m,
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        });
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("FinalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems", "identity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FinalPrice = 69.99m,
                            OrderId = 1,
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            FinalPrice = 199.98m,
                            OrderId = 2,
                            ProductId = 2,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 3,
                            FinalPrice = 129.99m,
                            OrderId = 2,
                            ProductId = 3,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments", "identity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AmountPaid = 329.97m,
                            OrderId = 2,
                            PaymentDate = new DateTime(2024, 12, 18, 14, 38, 13, 959, DateTimeKind.Local).AddTicks(3665),
                            PaymentMethod = 0,
                            PaymentStatus = 1,
                            UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        },
                        new
                        {
                            Id = 2,
                            AmountPaid = 69.99m,
                            OrderId = 1,
                            PaymentDate = new DateTime(2024, 12, 18, 14, 38, 13, 959, DateTimeKind.Local).AddTicks(3667),
                            PaymentMethod = 0,
                            PaymentStatus = 1,
                            UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        });
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmounInStock")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", "identity");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            AmounInStock = 30,
                            CategoryId = 1,
                            Description = "Stereo gaming headset with superior sound quality and comfort.",
                            ImageUrl = "https://pcbuild.bg/assets/products/000/000/305/000000305273--geimarski-slushalki-razer-kraken-v3-x-wired-usb-gaming-headset-rz04-03750300-r3m1.jpg",
                            Name = "Razer Kraken Headphones",
                            Price = 99.99m
                        },
                        new
                        {
                            Id = 3,
                            AmounInStock = 40,
                            CategoryId = 3,
                            Description = "Mechanical gaming keyboard with RGB lighting and customizable keys.",
                            ImageUrl = "https://m.media-amazon.com/images/I/61Az2uOUbqL._AC_UF894,1000_QL80_.jpg",
                            Name = "Razer BlackWidow V3 Keyboard",
                            Price = 129.99m
                        },
                        new
                        {
                            Id = 1,
                            AmounInStock = 50,
                            CategoryId = 4,
                            Description = "High-performance ergonomic gaming mouse with optical sensor.",
                            ImageUrl = "https://pcbuild.bg/assets/products/000/000/285/000000285414--geimarska-mishka-razer-basilisk-v3-pro-ergonomic-wireless-gaming-mouse-rz01-04620100-r3g1.jpg",
                            Name = "Razer DeathAdder V2 Mouse",
                            Price = 69.99m
                        });
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews", "identity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "The mouse is great but razer loves installing malware",
                            CreatedAt = new DateTime(2024, 12, 18, 14, 38, 13, 961, DateTimeKind.Local).AddTicks(2684),
                            ProductId = 1,
                            Rating = 4,
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        });
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePictureUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers", "identity");

                    b.HasData(
                        new
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            Address = "5 Vitosha Boulevard, Sofia",
                            ConcurrencyStamp = "ff51ffe0-0b7b-4ebe-8d2b-bbdbdad4b616",
                            CreatedAt = new DateTime(2024, 12, 18, 14, 38, 13, 947, DateTimeKind.Local).AddTicks(279),
                            DateOfBirth = new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "peter@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "PETER@GMAIL.COM",
                            NormalizedUserName = "PETER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKeQa9F1+EDHM/CCx2jRSyLDDFlBbcAHIKxM+NAix6OSzg2C9uyou2jP3/GzvTCrfg==",
                            PhoneNumberConfirmed = false,
                            ProfilePictureUrl = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png",
                            SecurityStamp = "2e371878-4dce-41ed-a152-9c73ec6d9c13",
                            TwoFactorEnabled = false,
                            UserName = "peter@gmail.com"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            Address = "100 Tsarigradsko Shose Blvd, Sofia",
                            ConcurrencyStamp = "ce17e579-92ee-4629-bc11-2a6879fa4190",
                            CreatedAt = new DateTime(2024, 12, 18, 14, 38, 13, 947, DateTimeKind.Local).AddTicks(9771),
                            DateOfBirth = new DateTime(1999, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "stoqn@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "STOQN@GMAIL.COM",
                            NormalizedUserName = "STOQN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPYov603lffQ2VwabI1JGOwPC44VIS3POsioWTE5AsrUAiSb1F2LsMc3vhaj110SZA==",
                            PhoneNumberConfirmed = false,
                            ProfilePictureUrl = "https://imgv3.fotor.com/images/blog-cover-image/10-profile-picture-ideas-to-make-you-stand-out.jpg",
                            SecurityStamp = "219088dc-8e9b-4557-bd53-41e0ea970241",
                            TwoFactorEnabled = false,
                            UserName = "stoqn@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TechGate.Infrastructure.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TechGate.Infrastructure.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechGate.Infrastructure.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TechGate.Infrastructure.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Order", b =>
                {
                    b.HasOne("TechGate.Infrastructure.Data.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.OrderItem", b =>
                {
                    b.HasOne("TechGate.Infrastructure.Data.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechGate.Infrastructure.Data.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Payment", b =>
                {
                    b.HasOne("TechGate.Infrastructure.Data.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechGate.Infrastructure.Data.Models.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Product", b =>
                {
                    b.HasOne("TechGate.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Review", b =>
                {
                    b.HasOne("TechGate.Infrastructure.Data.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechGate.Infrastructure.Data.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("TechGate.Infrastructure.Data.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Payments");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
