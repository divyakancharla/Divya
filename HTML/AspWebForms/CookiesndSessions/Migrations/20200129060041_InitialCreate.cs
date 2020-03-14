using Microsoft.EntityFrameworkCore.Migrations;

namespace CookiesndSessions.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userAccounts",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userAccounts", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userAccounts");
        }
    }
}
