using Microsoft.EntityFrameworkCore.Migrations;

namespace EarlyOneTask.Migrations
{
    public partial class SessionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountSession",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(nullable: true),
                    AccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountSession_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AccountSession",
                columns: new[] { "Id", "AccountId", "Token" },
                values: new object[] { 1, 1, "bc0b93b6-3754-4690-b197-98397e77d655" });

            migrationBuilder.InsertData(
                table: "AccountSession",
                columns: new[] { "Id", "AccountId", "Token" },
                values: new object[] { 2, 2, "8feeb6d2-a621-476f-b65e-f2a97c4e3dbf" });

            migrationBuilder.InsertData(
                table: "AccountSession",
                columns: new[] { "Id", "AccountId", "Token" },
                values: new object[] { 3, 3, "e75de01b-cbf5-4692-a70f-36e41cd103da" });

            migrationBuilder.CreateIndex(
                name: "IX_AccountSession_AccountId",
                table: "AccountSession",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountSession");
        }
    }
}
