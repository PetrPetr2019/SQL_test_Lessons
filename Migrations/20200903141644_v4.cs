using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleStaff.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "odate",
                "orderses",
                "odate",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "odate",
                "orderses",
                "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "odate");
        }
    }
}