using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store_System.Migrations
{
    public partial class branchNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Branch_Branch_Id",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "Branch_Id",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Branch_Branch_Id",
                table: "User",
                column: "Branch_Id",
                principalTable: "Branch",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Branch_Branch_Id",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "Branch_Id",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Branch_Branch_Id",
                table: "User",
                column: "Branch_Id",
                principalTable: "Branch",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
