using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Infrastructure.Persistence.Migrations
{
    public partial class ModificationrelatioshipBookandInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Inventory_BookId",
                table: "Inventory");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_BookId",
                table: "Inventory",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Inventory_BookId",
                table: "Inventory");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_BookId",
                table: "Inventory",
                column: "BookId",
                unique: true);
        }
    }
}
