using Microsoft.EntityFrameworkCore.Migrations;

namespace Moon.Migrations
{
    public partial class readd2pricing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PColoe",
                table: "Pricings",
                newName: "PColor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PColor",
                table: "Pricings",
                newName: "PColoe");
        }
    }
}
