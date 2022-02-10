﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestManagement.Infrastructure;

#nullable disable

namespace TestManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ThynkContext))]
    [Migration("20220210052106_ChangedRelation")]
    partial class ChangedRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TestManagement.Domain.Entities.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BookDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BookingDate");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TestCenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UpdateGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("_bookingStatus")
                        .HasColumnType("int")
                        .HasColumnName("BookingStatus");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("TestCenterId");

                    b.HasIndex("_bookingStatus");

                    b.ToTable("Booking", "covid");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.Result", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ResultIssuedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ResultIssueDate");

                    b.Property<Guid>("SpecimenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UpdateGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("_resultStatusId")
                        .HasColumnType("int")
                        .HasColumnName("ResultStatusId");

                    b.HasKey("Id");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("_resultStatusId");

                    b.ToTable("Result", "covid");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.SpecimenInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CollectionDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdateGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("_specimenTypeId")
                        .HasColumnType("int")
                        .HasColumnName("SpecimenTypeId");

                    b.HasKey("Id");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("_specimenTypeId");

                    b.ToTable("SpecimenInformation", "covid");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.TestCenter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AvailableFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AvailableUntil")
                        .HasColumnType("datetime2");

                    b.Property<long>("Capacity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValue(0L);

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<Guid?>("UpdateGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("Name"), false);

                    b.ToTable("TestCenter", "covid");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.TestCenterAvailableCapacity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("AvailableSpace")
                        .HasColumnType("bigint");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TestCenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UpdateGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("TestCenterId")
                        .IsUnique();

                    b.ToTable("TestCenterAvailableCapacity", "covid");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.TestCenterLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailablBefore")
                        .HasColumnType("int");

                    b.Property<int>("AvailableAfter")
                        .HasColumnType("int");

                    b.Property<int>("BookedValue")
                        .HasColumnType("int");

                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TestCenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UpdateGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("TestCenterId");

                    b.HasIndex("UserId");

                    b.ToTable("TestCenterInventory", "covid");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UpdateGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("_genderId")
                        .HasColumnType("int")
                        .HasColumnName("GenderId");

                    b.Property<int>("_roleId")
                        .HasColumnType("int")
                        .HasColumnName("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("Email"), false);

                    b.HasIndex("FirstName");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("FirstName"), false);

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("LastName");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("LastName"), false);

                    b.HasIndex("_genderId");

                    b.HasIndex("_roleId");

                    b.ToTable("User", "covid");
                });

            modelBuilder.Entity("TestManagement.Domain.Enumerations.BookingStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("BookingStatus", "enum");
                });

            modelBuilder.Entity("TestManagement.Domain.Enumerations.Gender", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Gender", "enum");
                });

            modelBuilder.Entity("TestManagement.Domain.Enumerations.ResultStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("ResultStatus", "enum");
                });

            modelBuilder.Entity("TestManagement.Domain.Enumerations.SpecimenTypes", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("SpecimenType", "enum");
                });

            modelBuilder.Entity("TestManagement.Domain.Enumerations.UserRoles", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("UserRole", "enum");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.Booking", b =>
                {
                    b.HasOne("TestManagement.Domain.Entities.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestManagement.Domain.Entities.TestCenter", "TestCenter")
                        .WithMany("Bookings")
                        .HasForeignKey("TestCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestManagement.Domain.Enumerations.BookingStatus", "BookingStatus")
                        .WithMany()
                        .HasForeignKey("_bookingStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingStatus");

                    b.Navigation("TestCenter");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.Result", b =>
                {
                    b.HasOne("TestManagement.Domain.Entities.Booking", "Booking")
                        .WithOne("Result")
                        .HasForeignKey("TestManagement.Domain.Entities.Result", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestManagement.Domain.Enumerations.ResultStatus", "Status")
                        .WithMany()
                        .HasForeignKey("_resultStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.SpecimenInformation", b =>
                {
                    b.HasOne("TestManagement.Domain.Entities.Booking", "Booking")
                        .WithOne("SpecimenInformation")
                        .HasForeignKey("TestManagement.Domain.Entities.SpecimenInformation", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestManagement.Domain.Enumerations.SpecimenTypes", "SpecimenTypes")
                        .WithMany()
                        .HasForeignKey("_specimenTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("SpecimenTypes");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.TestCenter", b =>
                {
                    b.OwnsOne("TestManagement.Domain.ValueObjects.TestCenterAddress", "Address", b1 =>
                        {
                            b1.Property<Guid>("TestCenterId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TestCenterId");

                            b1.ToTable("TestCenter", "covid");

                            b1.WithOwner()
                                .HasForeignKey("TestCenterId");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.TestCenterAvailableCapacity", b =>
                {
                    b.HasOne("TestManagement.Domain.Entities.TestCenter", "TestCenter")
                        .WithOne("TestCenterAvailableCapacity")
                        .HasForeignKey("TestManagement.Domain.Entities.TestCenterAvailableCapacity", "TestCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TestCenter");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.TestCenterLog", b =>
                {
                    b.HasOne("TestManagement.Domain.Entities.Booking", "Booking")
                        .WithOne("TestCenterLog")
                        .HasForeignKey("TestManagement.Domain.Entities.TestCenterLog", "BookingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestManagement.Domain.Entities.TestCenter", "TestCenter")
                        .WithMany("TestCenterLogs")
                        .HasForeignKey("TestCenterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TestManagement.Domain.Entities.User", "User")
                        .WithMany("TestCenterLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("TestCenter");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.User", b =>
                {
                    b.HasOne("TestManagement.Domain.Enumerations.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("_genderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestManagement.Domain.Enumerations.UserRoles", "UserRole")
                        .WithMany()
                        .HasForeignKey("_roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.Booking", b =>
                {
                    b.Navigation("Result")
                        .IsRequired();

                    b.Navigation("SpecimenInformation")
                        .IsRequired();

                    b.Navigation("TestCenterLog")
                        .IsRequired();
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.TestCenter", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("TestCenterAvailableCapacity")
                        .IsRequired();

                    b.Navigation("TestCenterLogs");
                });

            modelBuilder.Entity("TestManagement.Domain.Entities.User", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("TestCenterLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
