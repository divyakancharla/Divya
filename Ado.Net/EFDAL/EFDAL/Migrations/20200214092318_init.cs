using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JoinDate",
                table: "Employe",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Employe",
                type: "Date",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Employe");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Employe",
                newName: "JoinDate");
        }
    }
}
