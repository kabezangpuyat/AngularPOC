// <auto-generated />
using System;
using MNV.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MNV.Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210314125329_InitialBuild")]
    partial class InitialBuild
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MNV.Domain.Entities.RefreshToken", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReplacedByToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime2");

                    b.Property<string>("RevokedByIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("RefreshToken", "dbo");
                });

            modelBuilder.Entity("MNV.Domain.Entities.Role", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Active");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint")
                        .HasColumnName("CreatedByID");

                    b.Property<DateTimeOffset>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 483, DateTimeKind.Unspecified).AddTicks(5433), new TimeSpan(0, 8, 0, 0, 0)))
                        .HasColumnName("DateCreated");

                    b.Property<DateTimeOffset?>("DateModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("DateModified");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("fbbf329c-9c2c-4bdc-a87e-0da87a61e29f"))
                        .HasColumnName("Key");

                    b.Property<long?>("ModifiedByID")
                        .HasColumnType("bigint")
                        .HasColumnName("ModifiedByID");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Role", "dbo");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Active = true,
                            DateCreated = new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 502, DateTimeKind.Unspecified).AddTicks(4086), new TimeSpan(0, 8, 0, 0, 0)),
                            Description = "Super Administrator",
                            Key = new Guid("2b7d30d0-8dc0-4343-9275-860e3959472e"),
                            Name = "Superadmin"
                        },
                        new
                        {
                            ID = 2L,
                            Active = true,
                            DateCreated = new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 502, DateTimeKind.Unspecified).AddTicks(4635), new TimeSpan(0, 8, 0, 0, 0)),
                            Description = "Administrator",
                            Key = new Guid("80b24d7b-8873-4e04-9b91-9fb70c07aacf"),
                            Name = "Administrator"
                        },
                        new
                        {
                            ID = 3L,
                            Active = true,
                            DateCreated = new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 502, DateTimeKind.Unspecified).AddTicks(4653), new TimeSpan(0, 8, 0, 0, 0)),
                            Description = "Guest",
                            Key = new Guid("e2a7b30a-face-4aea-ae6e-af57b2634daa"),
                            Name = "Guest"
                        });
                });

            modelBuilder.Entity("MNV.Domain.Entities.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Active");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint")
                        .HasColumnName("CreatedByID");

                    b.Property<DateTimeOffset>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 496, DateTimeKind.Unspecified).AddTicks(3266), new TimeSpan(0, 8, 0, 0, 0)))
                        .HasColumnName("DateCreated");

                    b.Property<DateTimeOffset?>("DateModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("DateModified");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirstName");

                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("61a1dbaa-d838-459b-a0ef-6eb347e6b57e"))
                        .HasColumnName("Key");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LastName");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedByID")
                        .HasColumnType("bigint")
                        .HasColumnName("ModifiedByID");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Username");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User", "dbo");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Active = true,
                            CreatedByID = 1L,
                            DateCreated = new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 504, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 8, 0, 0, 0)),
                            Email = "mcnielv@gmail.com",
                            FirstName = "McNiel",
                            Key = new Guid("2b7d30d0-8dc0-4343-9275-860e3959472e"),
                            LastName = "Viray",
                            MiddleName = "N",
                            Password = "Pasok12345",
                            Username = "mcnielv@gmail.com"
                        },
                        new
                        {
                            ID = 2L,
                            Active = true,
                            CreatedByID = 1L,
                            DateCreated = new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 504, DateTimeKind.Unspecified).AddTicks(3751), new TimeSpan(0, 8, 0, 0, 0)),
                            Email = "mcniel.viray@gmail.com",
                            FirstName = "McNiel",
                            Key = new Guid("80b24d7b-8873-4e04-9b91-9fb70c07aacf"),
                            LastName = "Viray II",
                            MiddleName = "N",
                            Password = "Pasok12345",
                            Username = "mcniel.viray@gmail.com"
                        });
                });

            modelBuilder.Entity("MNV.Domain.Entities.UserRole", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Active");

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint")
                        .HasColumnName("CreatedByID");

                    b.Property<DateTimeOffset>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 499, DateTimeKind.Unspecified).AddTicks(8510), new TimeSpan(0, 8, 0, 0, 0)))
                        .HasColumnName("DateCreated");

                    b.Property<DateTimeOffset?>("DateModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("DateModified");

                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("dc96aa78-6a8a-4809-954a-335c1183b9e9"))
                        .HasColumnName("Key");

                    b.Property<long?>("ModifiedByID")
                        .HasColumnType("bigint")
                        .HasColumnName("ModifiedByID");

                    b.Property<long>("RoleID")
                        .HasColumnType("bigint")
                        .HasColumnName("RoleID");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint")
                        .HasColumnName("UserID");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRole", "dbo");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Active = true,
                            DateCreated = new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 504, DateTimeKind.Unspecified).AddTicks(7426), new TimeSpan(0, 8, 0, 0, 0)),
                            Key = new Guid("2b7d30d0-8dc0-4343-9275-860e3959472e"),
                            RoleID = 1L,
                            UserID = 1L
                        },
                        new
                        {
                            ID = 2L,
                            Active = true,
                            DateCreated = new DateTimeOffset(new DateTime(2021, 3, 14, 20, 53, 28, 504, DateTimeKind.Unspecified).AddTicks(7467), new TimeSpan(0, 8, 0, 0, 0)),
                            Key = new Guid("80b24d7b-8873-4e04-9b91-9fb70c07aacf"),
                            RoleID = 3L,
                            UserID = 2L
                        });
                });

            modelBuilder.Entity("MNV.Domain.Entities.RefreshToken", b =>
                {
                    b.HasOne("MNV.Domain.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MNV.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("MNV.Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MNV.Domain.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MNV.Domain.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("MNV.Domain.Entities.User", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
