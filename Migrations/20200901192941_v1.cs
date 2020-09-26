using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleStaff.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "customerses",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cnum = table.Column<int>(nullable: false),
                    sity = table.Column<string>(nullable: true),
                    rating = table.Column<int>(nullable: false),
                    snum = table.Column<int>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_customerses", x => x.Id); });

            migrationBuilder.CreateTable(
                "orderses",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    onum = table.Column<int>(nullable: false),
                    amt = table.Column<double>(nullable: false),
                    odate = table.Column<DateTime>(nullable: false),
                    cnum = table.Column<int>(nullable: false),
                    snum = table.Column<int>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_orderses", x => x.Id); });

            migrationBuilder.CreateTable(
                "salespeoples",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    snum = table.Column<int>(nullable: false),
                    sname = table.Column<string>(nullable: true),
                    sity = table.Column<string>(nullable: true),
                    comm = table.Column<double>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_salespeoples", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "customerses");

            migrationBuilder.DropTable(
                "orderses");

            migrationBuilder.DropTable(
                "salespeoples");
        }
    }
}