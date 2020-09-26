using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleStaff.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "cname",
                "customerses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "cname",
                "customerses");
        }
    }
}