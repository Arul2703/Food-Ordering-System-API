﻿// <auto-generated />
using System;
using AccountAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodOrderingSystemAPI.Migrations
{
    [DbContext(typeof(FoodAppDbContext))]
    [Migration("20230810091530_ColumnsModified")]
    partial class ColumnsModified
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("foodItemId")
                        .HasColumnType("int");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<float>("totalAmount")
                        .HasColumnType("real");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.Checkout", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("CheckoutDetails");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.FoodCategory", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("name");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.FoodItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("FoodCategoryname")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("calories")
                        .HasColumnType("real");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isVegan")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("FoodCategoryname");

                    b.ToTable("FoodItems");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.InvoiceModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Total_Bill")
                        .HasColumnType("real");

                    b.Property<DateTime?>("dateOfInvoice")
                        .HasColumnType("datetime2");

                    b.Property<string>("transactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("userId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("invoiceModel");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("FkFoodItemId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("FkInvoiceID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<float>("orderBill")
                        .HasColumnType("real");

                    b.Property<DateTime?>("orderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("orderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("unitPrice")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("FkFoodItemId");

                    b.HasIndex("FkInvoiceID");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.OtpModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("otpValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("otpModels");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.SignupLogin", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("confirmPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("rememberMe")
                        .HasColumnType("bit");

                    b.HasKey("userId");

                    b.ToTable("SignupLogin");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.UserProfile", b =>
                {
                    b.Property<int>("profileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("profileId"));

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("pincode")
                        .HasColumnType("int");

                    b.Property<byte[]>("profilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("profileId");

                    b.HasIndex("userId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.FoodItem", b =>
                {
                    b.HasOne("FoodOrderingSystemAPI.Models.FoodCategory", null)
                        .WithMany("items")
                        .HasForeignKey("FoodCategoryname");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.InvoiceModel", b =>
                {
                    b.HasOne("FoodOrderingSystemAPI.Models.SignupLogin", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.Order", b =>
                {
                    b.HasOne("FoodOrderingSystemAPI.Models.FoodItem", "foodItems")
                        .WithMany()
                        .HasForeignKey("FkFoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodOrderingSystemAPI.Models.InvoiceModel", "invoices")
                        .WithMany()
                        .HasForeignKey("FkInvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("foodItems");

                    b.Navigation("invoices");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.OtpModel", b =>
                {
                    b.HasOne("FoodOrderingSystemAPI.Models.SignupLogin", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.UserProfile", b =>
                {
                    b.HasOne("FoodOrderingSystemAPI.Models.SignupLogin", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("FoodOrderingSystemAPI.Models.FoodCategory", b =>
                {
                    b.Navigation("items");
                });
#pragma warning restore 612, 618
        }
    }
}
