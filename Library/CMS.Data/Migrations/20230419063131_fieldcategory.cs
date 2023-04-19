using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Data.Migrations
{
    public partial class fieldcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "tblTopic",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "tblTopic");
        }
    }
}
