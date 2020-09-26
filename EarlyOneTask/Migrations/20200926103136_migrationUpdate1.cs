using Microsoft.EntityFrameworkCore.Migrations;

namespace EarlyOneTask.Migrations
{
    public partial class migrationUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentScore",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentScore",
                table: "StudentScore",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AccountSession",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: "e5367300-a234-4daa-b53a-b8cf693ff00d");

            migrationBuilder.UpdateData(
                table: "AccountSession",
                keyColumn: "Id",
                keyValue: 2,
                column: "Token",
                value: "01e1095d-6227-4d37-adeb-6531da4f81d8");

            migrationBuilder.UpdateData(
                table: "AccountSession",
                keyColumn: "Id",
                keyValue: 3,
                column: "Token",
                value: "497fd69a-00cb-4489-867e-17fc98451f51");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentScore",
                table: "StudentScore");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentScore");

            migrationBuilder.UpdateData(
                table: "AccountSession",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: "bc0b93b6-3754-4690-b197-98397e77d655");

            migrationBuilder.UpdateData(
                table: "AccountSession",
                keyColumn: "Id",
                keyValue: 2,
                column: "Token",
                value: "8feeb6d2-a621-476f-b65e-f2a97c4e3dbf");

            migrationBuilder.UpdateData(
                table: "AccountSession",
                keyColumn: "Id",
                keyValue: 3,
                column: "Token",
                value: "e75de01b-cbf5-4692-a70f-36e41cd103da");
        }
    }
}
