﻿// <auto-generated />
using System;
using ClassLibraryAssignment.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassLibraryAssignment.Migrations
{
    [DbContext(typeof(Contextt))]
    partial class ContexttModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassLibraryAssignment.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Itemname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Itemprice")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("ClassLibraryAssignment.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("date");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("date");

                    b.HasKey("OrderId");

                    b.HasIndex("ItemId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ClassLibraryAssignment.Models.Order", b =>
                {
                    b.HasOne("ClassLibraryAssignment.Models.Item", "item")
                        .WithMany("orders")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
