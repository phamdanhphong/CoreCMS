using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCMS.Data.EF.Migrations
{
    public partial class initinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false),
                    Avatar = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Groups_Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Params = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageKeys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageKeyTitle = table.Column<string>(maxLength: 1000, nullable: true),
                    LanguageKeyDesc = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageNationals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageNationalName = table.Column<string>(maxLength: 255, nullable: true),
                    LanguageNationalFlag = table.Column<string>(maxLength: 255, nullable: true),
                    LanguageNationalDesc = table.Column<string>(maxLength: 255, nullable: true),
                    LanguageNationalEnable = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageNationals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(maxLength: 300, nullable: true),
                    Ip = table.Column<string>(maxLength: 300, nullable: true),
                    Info = table.Column<string>(maxLength: 300, nullable: true),
                    Author = table.Column<string>(maxLength: 300, nullable: true),
                    Type = table.Column<string>(maxLength: 300, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Property = table.Column<string>(maxLength: 255, nullable: true),
                    Account = table.Column<string>(maxLength: 255, nullable: true),
                    Password = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Address = table.Column<string>(maxLength: 255, nullable: true),
                    Phone = table.Column<string>(maxLength: 255, nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    IdentityCard = table.Column<string>(maxLength: 255, nullable: true),
                    Relationship = table.Column<string>(maxLength: 255, nullable: true),
                    Edu = table.Column<string>(maxLength: 255, nullable: true),
                    Job = table.Column<string>(maxLength: 255, nullable: true),
                    YahooNick = table.Column<string>(maxLength: 255, nullable: true),
                    Image = table.Column<string>(maxLength: 255, nullable: true),
                    PasswordQuestion = table.Column<string>(maxLength: 255, nullable: true),
                    PasswordAnswer = table.Column<string>(maxLength: 255, nullable: true),
                    IsApproved = table.Column<int>(nullable: false),
                    IsLockedOut = table.Column<int>(nullable: false),
                    Createdate = table.Column<DateTime>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: false),
                    LastChangePasswordDate = table.Column<DateTime>(nullable: false),
                    LastLogOutDate = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    TotalLogin = table.Column<int>(nullable: false),
                    Totalview = table.Column<int>(nullable: false),
                    Weight = table.Column<string>(maxLength: 255, nullable: true),
                    Height = table.Column<string>(maxLength: 255, nullable: true),
                    Blast = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 1500, nullable: true),
                    Content = table.Column<string>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description1 = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    App = table.Column<string>(maxLength: 50, nullable: true),
                    Level = table.Column<int>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    ParentsId = table.Column<string>(maxLength: 255, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    Image = table.Column<string>(maxLength: 1000, nullable: true),
                    SeoPageTitle = table.Column<string>(nullable: true),
                    SeoAlias = table.Column<string>(nullable: true),
                    SeoKeywords = table.Column<string>(nullable: true),
                    SeoDescription = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Params1 = table.Column<string>(nullable: true),
                    Params2 = table.Column<string>(nullable: true),
                    Params3 = table.Column<string>(nullable: true),
                    Params4 = table.Column<string>(nullable: true),
                    Params5 = table.Column<string>(nullable: true),
                    Iparams1 = table.Column<int>(nullable: true),
                    Iparams2 = table.Column<int>(nullable: true),
                    Iparams3 = table.Column<int>(nullable: true),
                    Iparams4 = table.Column<int>(nullable: true),
                    Iparams5 = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    GroupItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Groups_Items_GroupItemId",
                        column: x => x.GroupItemId,
                        principalTable: "Groups_Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LanguageItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageNationalId = table.Column<int>(nullable: false),
                    LanguageKeyId = table.Column<int>(nullable: false),
                    LanguageItemTitle = table.Column<string>(type: "ntext", nullable: true),
                    LanguageItemDesc = table.Column<string>(nullable: true),
                    LanguageItemParams = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageItems_LanguageKeys_LanguageKeyId",
                        column: x => x.LanguageKeyId,
                        principalTable: "LanguageKeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageItems_LanguageNationals_LanguageNationalId",
                        column: x => x.LanguageNationalId,
                        principalTable: "LanguageNationals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    GroupId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Key = table.Column<string>(maxLength: 255, nullable: true),
                    App = table.Column<string>(maxLength: 255, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    Image = table.Column<string>(maxLength: 1000, nullable: true),
                    Url = table.Column<string>(maxLength: 1000, nullable: true),
                    Author = table.Column<string>(maxLength: 1000, nullable: true),
                    TotalView = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    SalesPrice = table.Column<decimal>(nullable: false),
                    SeoPageTitle = table.Column<string>(nullable: true),
                    SeoAlias = table.Column<string>(nullable: true),
                    SeoKeywords = table.Column<string>(nullable: true),
                    SeoDescription = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Params1 = table.Column<string>(nullable: true),
                    Params2 = table.Column<string>(nullable: true),
                    Params3 = table.Column<string>(nullable: true),
                    Params4 = table.Column<string>(nullable: true),
                    Params5 = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    GroupItemId = table.Column<int>(nullable: true),
                    SubItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Groups_Items_GroupItemId",
                        column: x => x.GroupItemId,
                        principalTable: "Groups_Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    App = table.Column<string>(maxLength: 255, nullable: true),
                    Key = table.Column<string>(maxLength: 255, nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    Image = table.Column<string>(maxLength: 1000, nullable: true),
                    Email = table.Column<string>(maxLength: 1000, nullable: true),
                    Author = table.Column<string>(maxLength: 1000, nullable: true),
                    Url = table.Column<string>(maxLength: 1000, nullable: true),
                    Params1 = table.Column<string>(nullable: true),
                    Params2 = table.Column<string>(nullable: true),
                    Params3 = table.Column<string>(nullable: true),
                    Params4 = table.Column<string>(nullable: true),
                    Params5 = table.Column<string>(nullable: true),
                    Iparams1 = table.Column<int>(nullable: false),
                    Iparams2 = table.Column<int>(nullable: false),
                    Iparams3 = table.Column<int>(nullable: false),
                    Iparams4 = table.Column<int>(nullable: false),
                    Iparams5 = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_GroupItemId",
                table: "Groups",
                column: "GroupItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GroupId",
                table: "Items",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GroupItemId",
                table: "Items",
                column: "GroupItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SubItemId",
                table: "Items",
                column: "SubItemId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageItems_LanguageKeyId",
                table: "LanguageItems",
                column: "LanguageKeyId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageItems_LanguageNationalId",
                table: "LanguageItems",
                column: "LanguageNationalId");

            migrationBuilder.CreateIndex(
                name: "IX_SubItems_ItemId",
                table: "SubItems",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_SubItems_SubItemId",
                table: "Items",
                column: "SubItemId",
                principalTable: "SubItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Groups_Items_GroupItemId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Groups_Items_GroupItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Groups_GroupId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_SubItems_SubItemId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "LanguageItems");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "LanguageKeys");

            migrationBuilder.DropTable(
                name: "LanguageNationals");

            migrationBuilder.DropTable(
                name: "Groups_Items");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "SubItems");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
