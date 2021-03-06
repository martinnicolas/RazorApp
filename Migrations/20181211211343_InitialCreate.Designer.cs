﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorApp.Models;

namespace RazorApp.Migrations
{
    [DbContext(typeof(RazorAppContext))]
    [Migration("20181211211343_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("RazorApp.Models.Persona", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombre");

                    b.Property<int>("NumeroDocumento");

                    b.HasKey("ID");

                    b.ToTable("Persona");
                });
#pragma warning restore 612, 618
        }
    }
}
