using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store_System.Migrations
{
    public partial class orderitemsKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Order_Order_Id",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Product_product_Id",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_Order_Id",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ProductID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "product_Id",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Order_Id",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID1",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID1",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                columns: new[] { "ProductID", "OrderID" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderID1",
                table: "OrderItems",
                column: "OrderID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductID1",
                table: "OrderItems",
                column: "ProductID1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Order_OrderID1",
                table: "OrderItems",
                column: "OrderID1",
                principalTable: "Order",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Product_ProductID1",
                table: "OrderItems",
                column: "ProductID1",
                principalTable: "Product",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Order_OrderID1",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Product_ProductID1",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderID1",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ProductID1",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "OrderID1",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductID1",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "product_Id",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order_Id",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                columns: new[] { "product_Id", "Order_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Order_Id",
                table: "OrderItems",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductID",
                table: "OrderItems",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Order_Order_Id",
                table: "OrderItems",
                column: "Order_Id",
                principalTable: "Order",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Product_product_Id",
                table: "OrderItems",
                column: "product_Id",
                principalTable: "Product",
                principalColumn: "ID");
        }
    }
}
