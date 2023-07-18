// <auto-generated />
using System;
using Blogifier.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blogifier.Data.Migrations.SqlServer
{
  [DbContext(typeof(SqlServerDbContext))]
  partial class SqlServerDbContextModelSnapshot : ModelSnapshot
  {
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "7.0.5")
          .HasAnnotation("Relational:MaxIdentifierLength", 128);

      SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

      modelBuilder.Entity("Blogifier.Identity.UserInfo", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasMaxLength(128)
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<int>("AccessFailedCount")
                      .HasColumnType("int");

            b.Property<string>("Avatar")
                      .HasMaxLength(1024)
                      .HasColumnType("nvarchar(1024)");

            b.Property<string>("Bio")
                      .HasMaxLength(2048)
                      .HasColumnType("nvarchar(2048)");

            b.Property<string>("ConcurrencyStamp")
                      .IsConcurrencyToken()
                      .HasMaxLength(64)
                      .HasColumnType("nvarchar(64)");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("datetime2")
                      .HasColumnOrder(0)
                      .HasDefaultValueSql("getdate()");

            b.Property<string>("Email")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<bool>("EmailConfirmed")
                      .HasColumnType("bit");

            b.Property<string>("Gender")
                      .HasMaxLength(32)
                      .HasColumnType("nvarchar(32)");

            b.Property<bool>("LockoutEnabled")
                      .HasColumnType("bit");

            b.Property<DateTimeOffset?>("LockoutEnd")
                      .HasColumnType("datetimeoffset");

            b.Property<string>("NickName")
                      .IsRequired()
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<string>("NormalizedEmail")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<string>("NormalizedUserName")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<string>("PasswordHash")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<string>("PhoneNumber")
                      .HasMaxLength(32)
                      .HasColumnType("nvarchar(32)");

            b.Property<bool>("PhoneNumberConfirmed")
                      .HasColumnType("bit");

            b.Property<string>("SecurityStamp")
                      .HasMaxLength(32)
                      .HasColumnType("nvarchar(32)");

            b.Property<int>("State")
                      .HasColumnType("int");

            b.Property<bool>("TwoFactorEnabled")
                      .HasColumnType("bit");

            b.Property<int>("Type")
                      .HasColumnType("int");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("datetime2")
                      .HasColumnOrder(1);

            b.Property<string>("UserName")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.HasKey("Id");

            b.HasIndex("NormalizedEmail")
                      .HasDatabaseName("EmailIndex");

            b.HasIndex("NormalizedUserName")
                      .IsUnique()
                      .HasDatabaseName("UserNameIndex")
                      .HasFilter("[NormalizedUserName] IS NOT NULL");

            b.ToTable("Users", (string)null);
          });

      modelBuilder.Entity("Blogifier.Newsletters.Newsletter", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("getdate()");

            b.Property<int>("PostId")
                      .HasColumnType("int");

            b.Property<bool>("Success")
                      .HasColumnType("bit");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("datetime2");

            b.HasKey("Id");

            b.HasIndex("PostId");

            b.ToTable("Newsletters");
          });

      modelBuilder.Entity("Blogifier.Newsletters.Subscriber", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<string>("Country")
                      .HasMaxLength(120)
                      .HasColumnType("nvarchar(120)");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("getdate()");

            b.Property<string>("Email")
                      .IsRequired()
                      .HasMaxLength(160)
                      .HasColumnType("nvarchar(160)");

            b.Property<string>("Ip")
                      .HasMaxLength(80)
                      .HasColumnType("nvarchar(80)");

            b.Property<string>("Region")
                      .HasMaxLength(120)
                      .HasColumnType("nvarchar(120)");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("datetime2");

            b.HasKey("Id");

            b.ToTable("Subscribers");
          });

      modelBuilder.Entity("Blogifier.Options.OptionInfo", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("getdate()");

            b.Property<string>("Key")
                      .IsRequired()
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("datetime2");

            b.Property<string>("Value")
                      .IsRequired()
                      .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.HasIndex("Key")
                      .IsUnique();

            b.ToTable("Options", (string)null);
          });

      modelBuilder.Entity("Blogifier.Shared.Category", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<string>("Content")
                      .IsRequired()
                      .HasMaxLength(120)
                      .HasColumnType("nvarchar(120)");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("getdate()");

            b.Property<string>("Description")
                      .HasMaxLength(255)
                      .HasColumnType("nvarchar(255)");

            b.HasKey("Id");

            b.ToTable("Categories");
          });

      modelBuilder.Entity("Blogifier.Shared.Post", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<string>("Content")
                      .IsRequired()
                      .HasColumnType("nvarchar(max)");

            b.Property<string>("Cover")
                      .HasMaxLength(160)
                      .HasColumnType("nvarchar(160)");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("getdate()");

            b.Property<string>("Description")
                      .IsRequired()
                      .HasMaxLength(450)
                      .HasColumnType("nvarchar(450)");

            b.Property<int>("PostType")
                      .HasColumnType("int");

            b.Property<DateTime?>("PublishedAt")
                      .HasColumnType("datetime2");

            b.Property<string>("Slug")
                      .IsRequired()
                      .HasMaxLength(160)
                      .HasColumnType("nvarchar(160)");

            b.Property<int>("State")
                      .HasColumnType("int");

            b.Property<string>("Title")
                      .IsRequired()
                      .HasMaxLength(160)
                      .HasColumnType("nvarchar(160)");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("datetime2");

            b.Property<int>("UserId")
                      .HasColumnType("int");

            b.Property<int>("Views")
                      .HasColumnType("int");

            b.HasKey("Id");

            b.HasIndex("Slug")
                      .IsUnique();

            b.HasIndex("UserId");

            b.ToTable("Posts", (string)null);
          });

      modelBuilder.Entity("Blogifier.Shared.PostCategory", b =>
          {
            b.Property<int>("PostId")
                      .HasColumnType("int");

            b.Property<int>("CategoryId")
                      .HasColumnType("int");

            b.HasKey("PostId", "CategoryId");

            b.HasIndex("CategoryId");

            b.ToTable("PostCategories", (string)null);
          });

      modelBuilder.Entity("Blogifier.Storages.Storage", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<string>("ContentType")
                      .IsRequired()
                      .HasMaxLength(128)
                      .HasColumnType("nvarchar(128)");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("getdate()");

            b.Property<DateTime?>("DeletedAt")
                      .HasColumnType("datetime2");

            b.Property<bool>("IsDeleted")
                      .HasColumnType("bit");

            b.Property<long>("Length")
                      .HasColumnType("bigint");

            b.Property<string>("Name")
                      .IsRequired()
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<string>("Path")
                      .IsRequired()
                      .HasMaxLength(2048)
                      .HasColumnType("nvarchar(2048)");

            b.Property<string>("Slug")
                      .IsRequired()
                      .HasMaxLength(2048)
                      .HasColumnType("nvarchar(2048)");

            b.Property<int>("Type")
                      .HasColumnType("int");

            b.Property<int>("UserId")
                      .HasColumnType("int");

            b.HasKey("Id");

            b.HasIndex("UserId");

            b.ToTable("Storages", (string)null);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<string>("ClaimType")
                      .HasMaxLength(16)
                      .HasColumnType("nvarchar(16)");

            b.Property<string>("ClaimValue")
                      .HasMaxLength(256)
                      .HasColumnType("nvarchar(256)");

            b.Property<int>("UserId")
                      .HasColumnType("int");

            b.HasKey("Id");

            b.HasIndex("UserId");

            b.ToTable("UserClaim", (string)null);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
          {
            b.Property<string>("LoginProvider")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("ProviderKey")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("ProviderDisplayName")
                      .HasMaxLength(128)
                      .HasColumnType("nvarchar(128)");

            b.Property<int>("UserId")
                      .HasColumnType("int");

            b.HasKey("LoginProvider", "ProviderKey");

            b.HasIndex("UserId");

            b.ToTable("UserLogin", (string)null);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
          {
            b.Property<int>("UserId")
                      .HasColumnType("int");

            b.Property<string>("LoginProvider")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("Name")
                      .HasColumnType("nvarchar(450)");

            b.Property<string>("Value")
                      .HasMaxLength(1024)
                      .HasColumnType("nvarchar(1024)");

            b.HasKey("UserId", "LoginProvider", "Name");

            b.ToTable("UserToken", (string)null);
          });

      modelBuilder.Entity("Blogifier.Newsletters.Newsletter", b =>
          {
            b.HasOne("Blogifier.Shared.Post", "Post")
                      .WithMany()
                      .HasForeignKey("PostId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.Navigation("Post");
          });

      modelBuilder.Entity("Blogifier.Shared.Post", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", "User")
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.Navigation("User");
          });

      modelBuilder.Entity("Blogifier.Shared.PostCategory", b =>
          {
            b.HasOne("Blogifier.Shared.Category", "Category")
                      .WithMany("PostCategories")
                      .HasForeignKey("CategoryId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.HasOne("Blogifier.Shared.Post", "Post")
                      .WithMany("PostCategories")
                      .HasForeignKey("PostId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.Navigation("Category");

            b.Navigation("Post");
          });

      modelBuilder.Entity("Blogifier.Storages.Storage", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", "User")
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.Navigation("User");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", null)
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", null)
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", null)
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Blogifier.Shared.Category", b =>
          {
            b.Navigation("PostCategories");
          });

      modelBuilder.Entity("Blogifier.Shared.Post", b =>
          {
            b.Navigation("PostCategories");
          });
#pragma warning restore 612, 618
    }
  }
}
