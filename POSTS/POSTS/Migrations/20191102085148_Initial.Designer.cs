﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POSTS.Models;

namespace POSTS.Migrations
{
    [DbContext(typeof(WorkoutContext))]
    [Migration("20191102085148_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("POSTS.Models.Workout", b =>
                {
                    b.Property<int>("WorkoutID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Date");

                    b.Property<int>("DistanceInMeters");

                    b.Property<long>("TimeInSeconds");

                    b.HasKey("WorkoutID");

                    b.ToTable("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}