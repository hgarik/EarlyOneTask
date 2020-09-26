using Microsoft.EntityFrameworkCore.Migrations;

namespace EarlyOneTask.Migrations
{
    public partial class migrationUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Account");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Account",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "RoleId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "RoleId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "RoleId" },
                values: new object[] { 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Account_RoleId",
                table: "Account",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Role_RoleId",
                table: "Account",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Role_RoleId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_RoleId",
                table: "Account");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Account");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
