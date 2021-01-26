﻿// <auto-generated />
using System;
using Forum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forum.Migrations
{
    [DbContext(typeof(ForumDatabaseContext))]
    [Migration("20210126150929_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Forum.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Forum.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("content")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnName("creation_date")
                        .HasColumnType("datetime");

                    b.Property<int>("CreatorId")
                        .HasColumnName("creator_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastEditionDate")
                        .HasColumnName("last_edition_date")
                        .HasColumnType("datetime");

                    b.Property<int>("PostId")
                        .HasColumnName("post_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("PostId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Forum.Models.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentId")
                        .HasColumnName("comment_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfAddition")
                        .HasColumnName("date_of_addition")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("Point");
                });

            modelBuilder.Entity("Forum.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnName("category_id")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("content")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnName("creation_date")
                        .HasColumnType("datetime");

                    b.Property<int>("CreatorId")
                        .HasColumnName("creator_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastEditionDate")
                        .HasColumnName("last_edition_date")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Forum.Models.PostTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostId")
                        .HasColumnName("post_id")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnName("tag_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("Forum.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Forum.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastPasswordChangedDate")
                        .HasColumnName("last_password_changed_date")
                        .HasColumnType("datetime");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnName("login")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Nick")
                        .IsRequired()
                        .HasColumnName("nick")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnName("registration_date")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Forum.Models.Comment", b =>
                {
                    b.HasOne("Forum.Models.User", "Creator")
                        .WithMany("Comment")
                        .HasForeignKey("CreatorId")
                        .HasConstraintName("FK_Comment_To_User")
                        .IsRequired();

                    b.HasOne("Forum.Models.Post", "Post")
                        .WithMany("Comment")
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK_Comment_To_Post")
                        .IsRequired();
                });

            modelBuilder.Entity("Forum.Models.Point", b =>
                {
                    b.HasOne("Forum.Models.Comment", "Comment")
                        .WithMany("Point")
                        .HasForeignKey("CommentId")
                        .HasConstraintName("FK_Points_To_Comment")
                        .IsRequired();

                    b.HasOne("Forum.Models.User", "User")
                        .WithMany("Point")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Points_To_User")
                        .IsRequired();
                });

            modelBuilder.Entity("Forum.Models.Post", b =>
                {
                    b.HasOne("Forum.Models.Category", "Category")
                        .WithMany("Post")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Post_To_Category")
                        .IsRequired();

                    b.HasOne("Forum.Models.User", "Creator")
                        .WithMany("Post")
                        .HasForeignKey("CreatorId")
                        .HasConstraintName("FK_Post_To_User")
                        .IsRequired();
                });

            modelBuilder.Entity("Forum.Models.PostTag", b =>
                {
                    b.HasOne("Forum.Models.Post", "Post")
                        .WithMany("PostTag")
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK_PostTags_To_Post")
                        .IsRequired();

                    b.HasOne("Forum.Models.Tag", "Tag")
                        .WithMany("PostTag")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_PostTags_To_Tag")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
