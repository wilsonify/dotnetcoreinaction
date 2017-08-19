﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ScmDataAccess;
using System;

namespace ScmDataAccess.Migrations
{
    [DbContext(typeof(ScmContext))]
    partial class ScmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-preview1-24937");

            modelBuilder.Entity("ScmDataAccess.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<int>("OrderThreshold");

                    b.Property<int?>("PartId");

                    b.HasKey("Id");

                    b.HasIndex("PartId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("ScmDataAccess.PartType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("ScmDataAccess.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int?>("PartId");

                    b.HasKey("Id");

                    b.HasIndex("PartId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ScmDataAccess.InventoryItem", b =>
                {
                    b.HasOne("ScmDataAccess.PartType", "Part")
                        .WithMany()
                        .HasForeignKey("PartId");
                });

            modelBuilder.Entity("ScmDataAccess.Supplier", b =>
                {
                    b.HasOne("ScmDataAccess.PartType", "Part")
                        .WithMany()
                        .HasForeignKey("PartId");
                });
        }
    }
}