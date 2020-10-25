﻿// <auto-generated />
using System;
using AutoParking_backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoParking_backend.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("Models.Parking", b =>
                {
                    b.Property<int>("ParkingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ParkingId");

                    b.ToTable("parkings");
                });

            modelBuilder.Entity("Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParkingId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("TypeCarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TypePlaceTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlaceId");

                    b.HasIndex("ParkingId");

                    b.HasIndex("TypeCarId");

                    b.HasIndex("TypePlaceTypeId");

                    b.ToTable("places");
                });

            modelBuilder.Entity("Models.Reserv", b =>
                {
                    b.Property<int>("ReservId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndPeriod")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlaceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartPeriod")
                        .HasColumnType("TEXT");

                    b.HasKey("ReservId");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("Models.TypeCar", b =>
                {
                    b.Property<int>("TypeCarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeCarName")
                        .HasColumnType("TEXT");

                    b.HasKey("TypeCarId");

                    b.ToTable("typeCars");
                });

            modelBuilder.Entity("Models.TypePlace", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeName")
                        .HasColumnType("TEXT");

                    b.HasKey("TypeId");

                    b.ToTable("typePlaces");
                });

            modelBuilder.Entity("Models.Place", b =>
                {
                    b.HasOne("Models.Parking", null)
                        .WithMany("Places")
                        .HasForeignKey("ParkingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.TypeCar", null)
                        .WithMany("Places")
                        .HasForeignKey("TypeCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.TypePlace", null)
                        .WithMany("Places")
                        .HasForeignKey("TypePlaceTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
