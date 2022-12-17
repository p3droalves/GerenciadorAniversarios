﻿// <auto-generated />
using GerenciadorAniversarios.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GerenciadorAniversarios.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20221217203003_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorAniversarios.Models.Aniversariante", b =>
                {
                    b.Property<int>("AniversarianteId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Aniversario");

                    b.Property<string>("Nome");

                    b.Property<string>("Sobrenome");

                    b.HasKey("AniversarianteId");

                    b.ToTable("Aniversariantes");
                });
#pragma warning restore 612, 618
        }
    }
}
