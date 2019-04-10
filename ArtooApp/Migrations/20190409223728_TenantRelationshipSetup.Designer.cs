﻿// <auto-generated />
using System;
using Artoo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtooApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190409223728_TenantRelationshipSetup")]
    partial class TenantRelationshipSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Artoo.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int?>("FactoryId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int?>("TechManagerId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("TechManagerId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Artoo.Models.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("Description");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("EmailId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Artoo.Models.EmailRule", b =>
                {
                    b.Property<int>("EmailRuleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PassionBrandId");

                    b.Property<int>("Result");

                    b.HasKey("EmailRuleId");

                    b.HasIndex("PassionBrandId");

                    b.ToTable("EmailRules");
                });

            modelBuilder.Entity("Artoo.Models.EmailRuleDetail", b =>
                {
                    b.Property<int>("EmailRuleDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("EmailId");

                    b.Property<int>("EmailRuleId");

                    b.HasKey("EmailRuleDetailId");

                    b.HasIndex("EmailId");

                    b.HasIndex("EmailRuleId");

                    b.ToTable("EmailRuleDetails");
                });

            modelBuilder.Entity("Artoo.Models.Factory", b =>
                {
                    b.Property<int>("FactoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("FactoryId");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("Artoo.Models.FinalWeek", b =>
                {
                    b.Property<int>("FinalWeekId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("FinalWeekDay");

                    b.Property<string>("Name");

                    b.Property<int?>("Week");

                    b.Property<int?>("Year");

                    b.HasKey("FinalWeekId");

                    b.ToTable("FinalWeeks");
                });

            modelBuilder.Entity("Artoo.Models.Inspection", b =>
                {
                    b.Property<int>("InspectionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApproveUsername");

                    b.Property<bool>("BookingStatus");

                    b.Property<string>("CustomerComment");

                    b.Property<DateTime>("DateChecked");

                    b.Property<string>("Description");

                    b.Property<string>("FactoryComment");

                    b.Property<int?>("FactoryId");

                    b.Property<string>("FactoryName");

                    b.Property<bool>("Faked");

                    b.Property<DateTime>("Final");

                    b.Property<DateTime>("FinalDate");

                    b.Property<bool>("FinalStatus");

                    b.Property<int?>("FinalWeekId");

                    b.Property<string>("IMAN");

                    b.Property<DateTime>("InspectDate");

                    b.Property<bool>("InspectStatus");

                    b.Property<bool?>("IsThirdParty");

                    b.Property<string>("Model");

                    b.Property<int>("NumberChecked");

                    b.Property<string>("OrderNumber");

                    b.Property<int>("OrderQuantity");

                    b.Property<int>("OrderType");

                    b.Property<string>("PONumber");

                    b.Property<string>("Parameter");

                    b.Property<int>("PassionBrandId");

                    b.Property<string>("PassionBrandName");

                    b.Property<int?>("ProductQuantityChecked");

                    b.Property<int>("Result");

                    b.Property<int?>("TechManagerId");

                    b.Property<string>("TechManagerName");

                    b.Property<string>("UserBookingId");

                    b.Property<string>("Username");

                    b.HasKey("InspectionId");

                    b.HasIndex("FactoryId");

                    b.HasIndex("FinalWeekId");

                    b.HasIndex("PassionBrandId");

                    b.HasIndex("TechManagerId");

                    b.HasIndex("UserBookingId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("Artoo.Models.InspectionMistakeDetail", b =>
                {
                    b.Property<int>("InspectionMistakeDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("InspectionId");

                    b.Property<int>("MistakeId");

                    b.Property<int?>("Quantity");

                    b.HasKey("InspectionMistakeDetailId");

                    b.HasIndex("InspectionId");

                    b.HasIndex("MistakeId");

                    b.ToTable("InspectionMistakeDetails");
                });

            modelBuilder.Entity("Artoo.Models.Mistake", b =>
                {
                    b.Property<int>("MistakeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<int>("ManualType");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("MistakeId");

                    b.ToTable("Mistakes");
                });

            modelBuilder.Entity("Artoo.Models.PassionBrand", b =>
                {
                    b.Property<int>("PassionBrandId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("PassionBrandId");

                    b.ToTable("PassionBrands");
                });

            modelBuilder.Entity("Artoo.Models.TechManager", b =>
                {
                    b.Property<int>("TechManagerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegister");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("TechManagerId");

                    b.ToTable("TechManagers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Artoo.Models.ApplicationUser", b =>
                {
                    b.HasOne("Artoo.Models.Factory", "Factory")
                        .WithMany()
                        .HasForeignKey("FactoryId");

                    b.HasOne("Artoo.Models.TechManager", "TechManager")
                        .WithMany()
                        .HasForeignKey("TechManagerId");
                });

            modelBuilder.Entity("Artoo.Models.EmailRule", b =>
                {
                    b.HasOne("Artoo.Models.PassionBrand", "PassionBrand")
                        .WithMany()
                        .HasForeignKey("PassionBrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Artoo.Models.EmailRuleDetail", b =>
                {
                    b.HasOne("Artoo.Models.Email", "Email")
                        .WithMany()
                        .HasForeignKey("EmailId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Artoo.Models.EmailRule", "EmailRule")
                        .WithMany()
                        .HasForeignKey("EmailRuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Artoo.Models.Inspection", b =>
                {
                    b.HasOne("Artoo.Models.Factory", "Factory")
                        .WithMany()
                        .HasForeignKey("FactoryId");

                    b.HasOne("Artoo.Models.FinalWeek", "FinalWeek")
                        .WithMany()
                        .HasForeignKey("FinalWeekId");

                    b.HasOne("Artoo.Models.PassionBrand", "PassionBrand")
                        .WithMany()
                        .HasForeignKey("PassionBrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Artoo.Models.TechManager", "TechManager")
                        .WithMany()
                        .HasForeignKey("TechManagerId");

                    b.HasOne("Artoo.Models.ApplicationUser", "UserBooking")
                        .WithMany()
                        .HasForeignKey("UserBookingId");
                });

            modelBuilder.Entity("Artoo.Models.InspectionMistakeDetail", b =>
                {
                    b.HasOne("Artoo.Models.Inspection", "Inspection")
                        .WithMany("MistakeLines")
                        .HasForeignKey("InspectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Artoo.Models.Mistake", "Mistake")
                        .WithMany()
                        .HasForeignKey("MistakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Artoo.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Artoo.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Artoo.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Artoo.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
