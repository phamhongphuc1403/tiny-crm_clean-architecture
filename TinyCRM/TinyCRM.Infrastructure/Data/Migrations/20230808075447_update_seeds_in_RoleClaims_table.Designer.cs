﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TinyCRM.Infrastructure.Data;

#nullable disable

namespace TinyCRM.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230808075447_update_seeds_in_RoleClaims_table")]
    partial class update_seeds_in_RoleClaims_table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "80bee362-64ca-42cc-aeb2-444d5f61b008",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "d8bc22dc-5c2d-41c7-bc22-6293121a1cef",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId", "ClaimType")
                        .IsUnique()
                        .HasFilter("[ClaimType] IS NOT NULL");

                    b.ToTable("RoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "Permission.User.View.Personal",
                            ClaimValue = "Can view personal user profile",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "Permission.User.View.Personal",
                            ClaimValue = "Can view personal user profile",
                            RoleId = "d8bc22dc-5c2d-41c7-bc22-6293121a1cef"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "Permission.User.View.All",
                            ClaimValue = "Can view all user profiles",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "Permission.User.Update.Personal",
                            ClaimValue = "Can update personal user profile",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "Permission.User.Update.Personal",
                            ClaimValue = "Can update personal user profile",
                            RoleId = "d8bc22dc-5c2d-41c7-bc22-6293121a1cef"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "Permission.User.Update.All",
                            ClaimValue = "Can update all user profiles",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "Permission.User.Delete.All",
                            ClaimValue = "Can delete all user profiles",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "Permission.User.Create",
                            ClaimValue = "Can create user",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "Permission.Account.View",
                            ClaimValue = "Can view accounts",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "Permission.Account.View",
                            ClaimValue = "Can view accounts",
                            RoleId = "d8bc22dc-5c2d-41c7-bc22-6293121a1cef"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "Permission.Account.Update",
                            ClaimValue = "Can update accounts",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "Permission.Account.Delete",
                            ClaimValue = "Can delete accounts",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "Permission.Account.Create",
                            ClaimValue = "Can create accounts",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "Permission.Contact.View",
                            ClaimValue = "Can view contacts",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 15,
                            ClaimType = "Permission.Contact.View",
                            ClaimValue = "Can view contacts",
                            RoleId = "d8bc22dc-5c2d-41c7-bc22-6293121a1cef"
                        },
                        new
                        {
                            Id = 16,
                            ClaimType = "Permission.Contact.Update",
                            ClaimValue = "Can update contacts",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 17,
                            ClaimType = "Permission.Contact.Delete",
                            ClaimValue = "Can delete contacts",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 18,
                            ClaimType = "Permission.Contact.Create",
                            ClaimValue = "Can create contacts",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 19,
                            ClaimType = "Permission.Lead.View",
                            ClaimValue = "Can view leads",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 20,
                            ClaimType = "Permission.Lead.View",
                            ClaimValue = "Can view leads",
                            RoleId = "d8bc22dc-5c2d-41c7-bc22-6293121a1cef"
                        },
                        new
                        {
                            Id = 21,
                            ClaimType = "Permission.Lead.Update",
                            ClaimValue = "Can update leads",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 22,
                            ClaimType = "Permission.Lead.Delete",
                            ClaimValue = "Can delete leads",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 23,
                            ClaimType = "Permission.Lead.Create",
                            ClaimValue = "Can create leads",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 24,
                            ClaimType = "Permission.Deal.View",
                            ClaimValue = "Can view deals",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 25,
                            ClaimType = "Permission.Deal.View",
                            ClaimValue = "Can view deals",
                            RoleId = "d8bc22dc-5c2d-41c7-bc22-6293121a1cef"
                        },
                        new
                        {
                            Id = 26,
                            ClaimType = "Permission.Deal.Update",
                            ClaimValue = "Can update deals",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 27,
                            ClaimType = "Permission.Deal.Delete",
                            ClaimValue = "Can delete deals",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 28,
                            ClaimType = "Permission.Deal.Create",
                            ClaimValue = "Can create deals",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 29,
                            ClaimType = "Permission.Product.View",
                            ClaimValue = "Can view products",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 30,
                            ClaimType = "Permission.Product.View",
                            ClaimValue = "Can view products",
                            RoleId = "d8bc22dc-5c2d-41c7-bc22-6293121a1cef"
                        },
                        new
                        {
                            Id = 31,
                            ClaimType = "Permission.Product.Update",
                            ClaimValue = "Can update products",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 32,
                            ClaimType = "Permission.Product.Delete",
                            ClaimValue = "Can delete products",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        },
                        new
                        {
                            Id = 33,
                            ClaimType = "Permission.Product.Create",
                            ClaimValue = "Can create products",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
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

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "d28888e9-2ba9-473a-a40f-e38cb54f9b35",
                            RoleId = "80bee362-64ca-42cc-aeb2-444d5f61b008"
                        });
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

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.AccountEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("ToSales")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.ContactEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.DealEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LeadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeadId")
                        .IsUnique();

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.DealProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DealId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("PricePerUnit")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DealId");

                    b.HasIndex("ProductId");

                    b.ToTable("DealsProducts");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.LeadEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisqualificationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DisqualificationReason")
                        .HasColumnType("int");

                    b.Property<double?>("EstimatedRevenue")
                        .HasColumnType("float");

                    b.Property<int?>("Source")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("StringId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StringId")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TinyCRM.Infrastructure.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d28888e9-2ba9-473a-a40f-e38cb54f9b35",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1415161f-ae5c-46a2-929a-60edda6cba35",
                            Email = "admin@123",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEOTJb6l8HOHh1wHnpiRDTaZCCyavpjEt27SSXd4toN9W1yY+1fx37d8AhWk3lyYcYg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "29bf979f-d7b1-4d7d-b6ac-1a9191759f5c",
                            TwoFactorEnabled = false
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
                    b.HasOne("TinyCRM.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TinyCRM.Infrastructure.Identity.ApplicationUser", null)
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

                    b.HasOne("TinyCRM.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TinyCRM.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.ContactEntity", b =>
                {
                    b.HasOne("TinyCRM.Domain.Entities.AccountEntity", "Account")
                        .WithMany("Contacts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Account");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.DealEntity", b =>
                {
                    b.HasOne("TinyCRM.Domain.Entities.LeadEntity", "Lead")
                        .WithOne("Deal")
                        .HasForeignKey("TinyCRM.Domain.Entities.DealEntity", "LeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.DealProductEntity", b =>
                {
                    b.HasOne("TinyCRM.Domain.Entities.DealEntity", "Deal")
                        .WithMany("DealsProducts")
                        .HasForeignKey("DealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TinyCRM.Domain.Entities.ProductEntity", "Product")
                        .WithMany("DealsProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deal");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.LeadEntity", b =>
                {
                    b.HasOne("TinyCRM.Domain.Entities.AccountEntity", "Customer")
                        .WithMany("Leads")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.AccountEntity", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Leads");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.DealEntity", b =>
                {
                    b.Navigation("DealsProducts");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.LeadEntity", b =>
                {
                    b.Navigation("Deal");
                });

            modelBuilder.Entity("TinyCRM.Domain.Entities.ProductEntity", b =>
                {
                    b.Navigation("DealsProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
