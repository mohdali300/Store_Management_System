using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store_System.Migrations
{
    public partial class ReturnedItemsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "ReturnedItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "ReturnedItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReturnedQuantity",
                table: "ReturnedItems",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "ReturnedItems");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "ReturnedItems");

            migrationBuilder.DropColumn(
                name: "ReturnedQuantity",
                table: "ReturnedItems");
        }
    }
}
