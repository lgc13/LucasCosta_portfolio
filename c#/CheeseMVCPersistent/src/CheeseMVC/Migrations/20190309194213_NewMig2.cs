using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeseMVC.Migrations
{
    public partial class NewMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CheeseMenuCheeseID",
                table: "CheeseMenus",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CheeseMenuMenuID",
                table: "CheeseMenus",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CheeseMenus_CheeseMenuCheeseID_CheeseMenuMenuID",
                table: "CheeseMenus",
                columns: new[] { "CheeseMenuCheeseID", "CheeseMenuMenuID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CheeseMenus_CheeseMenus_CheeseMenuCheeseID_CheeseMenuMenuID",
                table: "CheeseMenus",
                columns: new[] { "CheeseMenuCheeseID", "CheeseMenuMenuID" },
                principalTable: "CheeseMenus",
                principalColumns: new[] { "CheeseID", "MenuID" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheeseMenus_CheeseMenus_CheeseMenuCheeseID_CheeseMenuMenuID",
                table: "CheeseMenus");

            migrationBuilder.DropIndex(
                name: "IX_CheeseMenus_CheeseMenuCheeseID_CheeseMenuMenuID",
                table: "CheeseMenus");

            migrationBuilder.DropColumn(
                name: "CheeseMenuCheeseID",
                table: "CheeseMenus");

            migrationBuilder.DropColumn(
                name: "CheeseMenuMenuID",
                table: "CheeseMenus");
        }
    }
}
