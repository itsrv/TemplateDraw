﻿// <auto-generated />
using System;
using FormSubmit.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FormSubmit.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20201021190516_AddDetailGroupIdToSubmitData")]
    partial class AddDetailGroupIdToSubmitData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FormSubmit.Models.FormData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<long?>("FormDetailid")
                        .HasColumnType("bigint");

                    b.Property<long>("FormId")
                        .HasColumnType("bigint");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InputId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InputLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InputName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormDetailid");

                    b.ToTable("FormData");
                });

            modelBuilder.Entity("FormSubmit.Models.FormDetail", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("FormDetail");
                });

            modelBuilder.Entity("FormSubmit.Models.SubmitData", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("DetailGroup")
                        .HasColumnType("bigint");

                    b.Property<long>("ElmId")
                        .HasColumnType("bigint");

                    b.Property<long>("FormId")
                        .HasColumnType("bigint");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("SubmitData");
                });

            modelBuilder.Entity("FormSubmit.Models.FormData", b =>
                {
                    b.HasOne("FormSubmit.Models.FormDetail", null)
                        .WithMany("FormData")
                        .HasForeignKey("FormDetailid");
                });
#pragma warning restore 612, 618
        }
    }
}
