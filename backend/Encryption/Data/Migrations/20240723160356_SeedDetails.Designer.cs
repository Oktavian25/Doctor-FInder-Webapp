﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend;

#nullable disable

namespace backend.Data.Migrations
{
    [DbContext(typeof(DoctorFinderContext))]
    [Migration("20240723160356_SeedDetails")]
    partial class SeedDetails
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("backend.ClinicEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clinics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Clinica Regina Maria"
                        },
                        new
                        {
                            Id = 2,
                            Name = "MedLife"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sanador"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Clinica Polisano"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Medicover"
                        });
                });

            modelBuilder.Entity("backend.DoctorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("clinicId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("specializationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("clinicId");

                    b.HasIndex("specializationId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("backend.SpecializationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Specializations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ORL"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Neurologie"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Oncologie"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Pediatrie"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chirurgie"
                        });
                });

            modelBuilder.Entity("backend.DoctorEntity", b =>
                {
                    b.HasOne("backend.ClinicEntity", "clinic")
                        .WithMany()
                        .HasForeignKey("clinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.SpecializationEntity", "specialization")
                        .WithMany()
                        .HasForeignKey("specializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clinic");

                    b.Navigation("specialization");
                });
#pragma warning restore 612, 618
        }
    }
}
