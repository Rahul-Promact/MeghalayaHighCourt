﻿// <auto-generated />
using System;
using MeghalayaHighCourt;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MeghalayaHighCourt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MeghalayaHighCourt.caseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Abbr")
                        .HasColumnType("text");

                    b.Property<string>("Act")
                        .HasColumnType("text");

                    b.Property<string>("Bench")
                        .HasColumnType("text");

                    b.Property<string>("BlaCitation")
                        .HasColumnType("text");

                    b.Property<string>("CaseName")
                        .HasColumnType("text");

                    b.Property<string>("CaseNo")
                        .HasColumnType("text");

                    b.Property<string>("CaseReferred")
                        .HasColumnType("text");

                    b.Property<string>("Citation")
                        .HasColumnType("text");

                    b.Property<string>("Coram")
                        .HasColumnType("text");

                    b.Property<int?>("CoramCount")
                        .HasColumnType("integer");

                    b.Property<string>("Counsel")
                        .HasColumnType("text");

                    b.Property<string>("Court")
                        .HasColumnType("text");

                    b.Property<string>("Dated")
                        .HasColumnType("text");

                    b.Property<string>("Filename")
                        .HasColumnType("text");

                    b.Property<string>("Headnotes")
                        .HasColumnType("text");

                    b.Property<string>("Overrule")
                        .HasColumnType("text");

                    b.Property<string>("OveruleBy")
                        .HasColumnType("text");

                    b.Property<string>("PdfLink")
                        .HasColumnType("text");

                    b.Property<string>("Petitioner")
                        .HasColumnType("text");

                    b.Property<string>("QrLink")
                        .HasColumnType("text");

                    b.Property<bool?>("Reportable")
                        .HasColumnType("boolean");

                    b.Property<string>("Respondent")
                        .HasColumnType("text");

                    b.Property<string>("Result")
                        .HasColumnType("text");

                    b.Property<string>("Ssd")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CaseDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
