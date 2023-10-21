﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApplication.Models.DB;

#nullable disable

namespace webapp.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20231021065239_MoreStuff")]
    partial class MoreStuff
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyWebApplication.Models.DB.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LOOKUPRoleID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("RowCreatedSYSUserID");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("RowCreatedDateTime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("RowModifiedSYSUserID");

                    b.Property<DateTime>("ModifiedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("RowModifiedDateTime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("RoleDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("RoleDescription");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("RoleName");

                    b.HasKey("RoleID");

                    b.ToTable("LOOKUPRole", (string)null);
                });

            modelBuilder.Entity("MyWebApplication.Models.DB.SystemUsers", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SYSUserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("RowCreatedSYSUserID");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("RowCreatedDateTime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("LoginName");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("RowModifiedSYSUserID");

                    b.Property<DateTime>("ModifiedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("RowModifiedDateTime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("PasswordEncryptedText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("SYSUser", (string)null);
                });

            modelBuilder.Entity("MyWebApplication.Models.DB.UserRole", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SYSUserRoleID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("RowCreatedSYSUserID");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("RowCreatedDateTime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<int>("LookUpRoleID")
                        .HasColumnType("int")
                        .HasColumnName("LOOKUPRoleID");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("RowModifiedSYSUserID");

                    b.Property<DateTime>("ModifiedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("RowModifiedDateTime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("UserID")
                        .HasColumnType("int")
                        .HasColumnName("SYSUserID");

                    b.HasKey("RoleID");

                    b.ToTable("SYSUserRole", (string)null);
                });

            modelBuilder.Entity("MyWebApplication.Models.DB.Users", b =>
                {
                    b.Property<int>("ProfileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SYSUserProfileID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileID"));

                    b.Property<string>("AccountImage")
                        .HasMaxLength(8000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8000)")
                        .HasColumnName("AccountImage");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("RowCreatedSYSUserID");

                    b.Property<DateTime>("CreatedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("RowCreatedDateTime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("char(1)")
                        .HasColumnName("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("LastName");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("RowModifiedSYSUserID");

                    b.Property<DateTime>("ModifiedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("RowModifiedDateTime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("UserID")
                        .HasColumnType("int")
                        .HasColumnName("SYSUserID");

                    b.HasKey("ProfileID");

                    b.ToTable("SYSUserProfile", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
