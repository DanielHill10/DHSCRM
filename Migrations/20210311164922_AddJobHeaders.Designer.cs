﻿// <auto-generated />
using System;
using DHSCRM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DHSCRM.Migrations
{
    [DbContext(typeof(RecordDetailContext))]
    [Migration("20210311164922_AddJobHeaders")]
    partial class AddJobHeaders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DHSCRM.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DHSCRM.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressPostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressStreet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DHSCRM.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JobDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobHeaderId")
                        .HasColumnType("int");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostcodeFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostcodeTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalMiles")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("JobId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("JobHeaderId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("DHSCRM.Models.JobHeader", b =>
                {
                    b.Property<int>("JobHeaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobHeaderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("JobHeader");
                });

            modelBuilder.Entity("DHSCRM.Models.Contact", b =>
                {
                    b.HasOne("DHSCRM.Models.Customer", "Customer")
                        .WithMany("Contacts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DHSCRM.Models.Job", b =>
                {
                    b.HasOne("DHSCRM.Models.Customer", "Customer")
                        .WithMany("Jobs")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DHSCRM.Models.JobHeader", null)
                        .WithMany("Jobs")
                        .HasForeignKey("JobHeaderId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DHSCRM.Models.JobHeader", b =>
                {
                    b.HasOne("DHSCRM.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DHSCRM.Models.Customer", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("DHSCRM.Models.JobHeader", b =>
                {
                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
