using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infinite_LMS_NETCore_MVC.Migrations
{
    public partial class Add_Description_To_CategoryItem_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CategoryItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CategoryItem");
        }
    }
}
