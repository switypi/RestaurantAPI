﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(RestaurentDbContext))]
    [Migration("20230615084542_15 june -2")]
    partial class _15june2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Infrastructure.Entities.Bill", b =>
                {
                    b.Property<long>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("BaseLineTotal")
                        .HasColumnType("REAL");

                    b.Property<string>("BillNumber")
                        .HasColumnType("TEXT");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("REAL");

                    b.Property<long?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("TaxAmount")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("REAL");

                    b.HasKey("BillId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("Infrastructure.Entities.Booking", b =>
                {
                    b.Property<long>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CustId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TableId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TableNum")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("BookingId");

                    b.HasIndex("CustId");

                    b.HasIndex("TableId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Infrastructure.Entities.Cashier", b =>
                {
                    b.Property<long>("CashierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Bdate")
                        .HasColumnType("BLOB");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fname")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("JoinDate")
                        .HasColumnType("BLOB");

                    b.Property<string>("Lname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.HasKey("CashierId");

                    b.ToTable("Cashier");
                });

            modelBuilder.Entity("Infrastructure.Entities.Cook", b =>
                {
                    b.Property<long>("CookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fname")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialization")
                        .HasColumnType("TEXT");

                    b.HasKey("CookId");

                    b.ToTable("Cook");
                });

            modelBuilder.Entity("Infrastructure.Entities.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Infrastructure.Entities.DeliveryBoy", b =>
                {
                    b.Property<long>("DeliveryBoyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fname")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.HasKey("DeliveryBoyId");

                    b.ToTable("DeliveryBoy");
                });

            modelBuilder.Entity("Infrastructure.Entities.HomeDelivery", b =>
                {
                    b.Property<long>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CustId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DeliveryId");

                    b.HasIndex("CustId");

                    b.HasIndex("OrderId");

                    b.ToTable("HomeDelivery");
                });

            modelBuilder.Entity("Infrastructure.Entities.Menu", b =>
                {
                    b.Property<long>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsVeg")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("MenuId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Infrastructure.Entities.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CustomerID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TableId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TableId")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Infrastructure.Entities.OrderDetails", b =>
                {
                    b.Property<long>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("MenuId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Infrastructure.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("OpeningClosingTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("Infrastructure.Entities.SaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Daily")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Date")
                        .HasColumnType("BLOB");

                    b.Property<long?>("Monthly")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rname")
                        .HasColumnType("TEXT");

                    b.Property<long?>("Weekly")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SaleDetail");
                });

            modelBuilder.Entity("Infrastructure.Entities.Supplier", b =>
                {
                    b.Property<long>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .HasColumnType("TEXT");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("Infrastructure.Entities.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TableNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("TableType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tag")
                        .HasColumnType("TEXT");

                    b.Property<long?>("WaiterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TableId");

                    b.HasIndex("WaiterId");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("Infrastructure.Entities.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Infrastructure.Entities.Waiter", b =>
                {
                    b.Property<long>("WaiterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fname")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TableId")
                        .HasColumnType("INTEGER");

                    b.HasKey("WaiterId");

                    b.ToTable("Waiter");
                });

            modelBuilder.Entity("Infrastructure.Entities.Bill", b =>
                {
                    b.HasOne("Infrastructure.Entities.Order", "Orders")
                        .WithOne("CurrentBill")
                        .HasForeignKey("Infrastructure.Entities.Bill", "OrderId");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Infrastructure.Entities.Booking", b =>
                {
                    b.HasOne("Infrastructure.Entities.Customer", "Cust")
                        .WithMany("Bookings")
                        .HasForeignKey("CustId");

                    b.HasOne("Infrastructure.Entities.Table", "TableNumNavigation")
                        .WithMany()
                        .HasForeignKey("TableId");

                    b.Navigation("Cust");

                    b.Navigation("TableNumNavigation");
                });

            modelBuilder.Entity("Infrastructure.Entities.HomeDelivery", b =>
                {
                    b.HasOne("Infrastructure.Entities.Customer", "Cust")
                        .WithMany("HomeDeliveries")
                        .HasForeignKey("CustId");

                    b.HasOne("Infrastructure.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.Navigation("Cust");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Infrastructure.Entities.Order", b =>
                {
                    b.HasOne("Infrastructure.Entities.Customer", "CurrentCustomer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.HasOne("Infrastructure.Entities.Table", "CurrentTable")
                        .WithOne("Orders")
                        .HasForeignKey("Infrastructure.Entities.Order", "TableId");

                    b.Navigation("CurrentCustomer");

                    b.Navigation("CurrentTable");
                });

            modelBuilder.Entity("Infrastructure.Entities.OrderDetails", b =>
                {
                    b.HasOne("Infrastructure.Entities.Order", "CurrentOrder")
                        .WithMany("CurrentOrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentOrder");
                });

            modelBuilder.Entity("Infrastructure.Entities.Table", b =>
                {
                    b.HasOne("Infrastructure.Entities.Waiter", null)
                        .WithMany("Tables")
                        .HasForeignKey("WaiterId");
                });

            modelBuilder.Entity("Infrastructure.Entities.Customer", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("HomeDeliveries");
                });

            modelBuilder.Entity("Infrastructure.Entities.Order", b =>
                {
                    b.Navigation("CurrentBill")
                        .IsRequired();

                    b.Navigation("CurrentOrderDetails");
                });

            modelBuilder.Entity("Infrastructure.Entities.Table", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Infrastructure.Entities.Waiter", b =>
                {
                    b.Navigation("Tables");
                });
#pragma warning restore 612, 618
        }
    }
}