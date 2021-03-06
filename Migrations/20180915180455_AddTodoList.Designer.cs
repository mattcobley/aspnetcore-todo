﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetcore_todo.Database;

namespace aspnetcoretodo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180915180455_AddTodoList")]
    partial class AddTodoList
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("aspnetcore_todo.Models.TodoItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.Property<int?>("TodoListid");

                    b.HasKey("id");

                    b.HasIndex("TodoListid");

                    b.ToTable("TodoItem");
                });

            modelBuilder.Entity("aspnetcore_todo.Models.TodoList", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("id");

                    b.ToTable("TodoLists");
                });

            modelBuilder.Entity("aspnetcore_todo.Models.TodoItem", b =>
                {
                    b.HasOne("aspnetcore_todo.Models.TodoList")
                        .WithMany("Items")
                        .HasForeignKey("TodoListid");
                });
#pragma warning restore 612, 618
        }
    }
}
