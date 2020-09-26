using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleStaff.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "odate",
                "orderses",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "odate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "odate",
                "orderses",
                "odate",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}