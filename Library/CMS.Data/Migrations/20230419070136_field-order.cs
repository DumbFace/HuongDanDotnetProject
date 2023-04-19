using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Data.Migrations
{
    public partial class fieldorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "tblCourse",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "tblCourse");
        }
    }
}
