using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCMS.Data.EF.Migrations
{
    public partial class updatedb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_SubItems_SubItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_SubItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SubItemId",
                table: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubItemId",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_SubItemId",
                table: "Items",
                column: "SubItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_SubItems_SubItemId",
                table: "Items",
                column: "SubItemId",
                principalTable: "SubItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
