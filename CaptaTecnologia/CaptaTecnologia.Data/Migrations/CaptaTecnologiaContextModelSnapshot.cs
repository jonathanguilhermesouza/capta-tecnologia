﻿// <auto-generated />
using CaptaTecnologia.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaptaTecnologia.Data.Migrations
{
    [DbContext(typeof(CaptaTecnologiaContext))]
    partial class CaptaTecnologiaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CaptaTecnologia.Domain.Entities.Candidate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderCodigo")
                        .HasMaxLength(1);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("GenderCodigo");

                    b.ToTable("Candidate","JOB");
                });

            modelBuilder.Entity("CaptaTecnologia.Domain.Entities.Gender", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(1);

                    b.Property<string>("Description")
                        .HasMaxLength(9);

                    b.HasKey("Codigo");

                    b.ToTable("Gender","SIS");
                });

            modelBuilder.Entity("CaptaTecnologia.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasMaxLength(10);

                    b.Property<string>("Username")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("User","ACCOUNT");
                });

            modelBuilder.Entity("CaptaTecnologia.Domain.Entities.Candidate", b =>
                {
                    b.HasOne("CaptaTecnologia.Domain.Entities.Gender", "Gender")
                        .WithMany("Candidate")
                        .HasForeignKey("GenderCodigo")
                        .HasConstraintName("FK_Candidate_Gender");
                });
#pragma warning restore 612, 618
        }
    }
}
