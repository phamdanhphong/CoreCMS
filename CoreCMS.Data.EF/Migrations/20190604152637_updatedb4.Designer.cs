﻿// <auto-generated />
using System;
using CoreCMS.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCMS.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190604152637_updatedb4")]
    partial class updatedb4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCMS.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("App")
                        .HasMaxLength(50);

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<int?>("GroupItemId");

                    b.Property<string>("Image")
                        .HasMaxLength(1000);

                    b.Property<int?>("Iparams1");

                    b.Property<int?>("Iparams2");

                    b.Property<int?>("Iparams3");

                    b.Property<int?>("Iparams4");

                    b.Property<int?>("Iparams5");

                    b.Property<int>("LanguageId");

                    b.Property<int?>("Level");

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("Params1");

                    b.Property<string>("Params2");

                    b.Property<string>("Params3");

                    b.Property<string>("Params4");

                    b.Property<string>("Params5");

                    b.Property<int?>("ParentId");

                    b.Property<string>("ParentsId")
                        .HasMaxLength(255);

                    b.Property<string>("SeoAlias");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeywords");

                    b.Property<string>("SeoPageTitle");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("GroupItemId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.GroupItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("GroupId");

                    b.Property<int>("ItemId");

                    b.Property<string>("Params");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Groups_Items");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("App")
                        .HasMaxLength(255);

                    b.Property<string>("Author")
                        .HasMaxLength(1000);

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<int>("GroupId");

                    b.Property<int?>("GroupItemId");

                    b.Property<string>("Image")
                        .HasMaxLength(1000);

                    b.Property<string>("Key")
                        .HasMaxLength(255);

                    b.Property<int>("LanguageId");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Params1");

                    b.Property<string>("Params2");

                    b.Property<string>("Params3");

                    b.Property<string>("Params4");

                    b.Property<string>("Params5");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("SalesPrice");

                    b.Property<string>("SeoAlias");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeywords");

                    b.Property<string>("SeoPageTitle");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.Property<int>("TotalView");

                    b.Property<string>("Url")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("GroupItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.LanguageItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageItemDesc");

                    b.Property<string>("LanguageItemParams");

                    b.Property<string>("LanguageItemTitle")
                        .HasColumnType("ntext");

                    b.Property<int>("LanguageKeyId");

                    b.Property<int>("LanguageNationalId");

                    b.HasKey("Id");

                    b.HasIndex("LanguageKeyId");

                    b.HasIndex("LanguageNationalId");

                    b.ToTable("LanguageItems");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.LanguageKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageKeyDesc")
                        .HasMaxLength(1000);

                    b.Property<string>("LanguageKeyTitle")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("LanguageKeys");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.LanguageNational", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageNationalDesc")
                        .HasMaxLength(255);

                    b.Property<int>("LanguageNationalEnable");

                    b.Property<string>("LanguageNationalFlag")
                        .HasMaxLength(255);

                    b.Property<string>("LanguageNationalName")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("LanguageNationals");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasMaxLength(300);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("Info")
                        .HasMaxLength(300);

                    b.Property<string>("Ip")
                        .HasMaxLength(300);

                    b.Property<string>("Type")
                        .HasMaxLength(300);

                    b.Property<string>("Url")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.Members", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .HasMaxLength(255);

                    b.Property<string>("Address")
                        .HasMaxLength(255);

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Blast")
                        .HasMaxLength(255);

                    b.Property<string>("Comment");

                    b.Property<DateTime>("Createdate");

                    b.Property<string>("Edu")
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .HasMaxLength(255);

                    b.Property<string>("Height")
                        .HasMaxLength(255);

                    b.Property<string>("IdentityCard")
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<int>("IsApproved");

                    b.Property<int>("IsLockedOut");

                    b.Property<string>("Job")
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastChangePasswordDate");

                    b.Property<DateTime>("LastLogOutDate");

                    b.Property<DateTime>("LastLoginDate");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .HasMaxLength(255);

                    b.Property<string>("PasswordAnswer")
                        .HasMaxLength(255);

                    b.Property<string>("PasswordQuestion")
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .HasMaxLength(255);

                    b.Property<string>("Property")
                        .HasMaxLength(255);

                    b.Property<string>("Relationship")
                        .HasMaxLength(255);

                    b.Property<int>("TotalLogin");

                    b.Property<int>("Totalview");

                    b.Property<string>("Weight")
                        .HasMaxLength(255);

                    b.Property<string>("YahooNick")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.Setting", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Content");

                    b.Property<string>("Description")
                        .HasMaxLength(1500);

                    b.Property<int>("LanguageId");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.SubItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("App")
                        .HasMaxLength(255);

                    b.Property<string>("Author")
                        .HasMaxLength(1000);

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Email")
                        .HasMaxLength(1000);

                    b.Property<string>("Image")
                        .HasMaxLength(1000);

                    b.Property<int>("Iparams1");

                    b.Property<int>("Iparams2");

                    b.Property<int>("Iparams3");

                    b.Property<int>("Iparams4");

                    b.Property<int>("Iparams5");

                    b.Property<int>("ItemId");

                    b.Property<string>("Key")
                        .HasMaxLength(255);

                    b.Property<int>("LanguageId");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Params1");

                    b.Property<string>("Params2");

                    b.Property<string>("Params3");

                    b.Property<string>("Params4");

                    b.Property<string>("Params5");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.Property<string>("Url")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("SubItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.Group", b =>
                {
                    b.HasOne("CoreCMS.Data.Entities.GroupItem", "GroupItem")
                        .WithMany("Groups")
                        .HasForeignKey("GroupItemId");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.Item", b =>
                {
                    b.HasOne("CoreCMS.Data.Entities.Group", "Group")
                        .WithMany("Items")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreCMS.Data.Entities.GroupItem", "GroupItem")
                        .WithMany("Items")
                        .HasForeignKey("GroupItemId");
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.LanguageItem", b =>
                {
                    b.HasOne("CoreCMS.Data.Entities.LanguageKey", "LanguageKeys")
                        .WithMany()
                        .HasForeignKey("LanguageKeyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreCMS.Data.Entities.LanguageNational", "LanguageNationals")
                        .WithMany()
                        .HasForeignKey("LanguageNationalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreCMS.Data.Entities.SubItem", b =>
                {
                    b.HasOne("CoreCMS.Data.Entities.Item", "Item")
                        .WithMany("SubItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
