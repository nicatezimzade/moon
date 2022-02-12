using Microsoft.EntityFrameworkCore.Migrations;

namespace Moon.Migrations
{
    public partial class readdpricing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PColoe",
                table: "Pricings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PFeat4",
                table: "Pricings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PFeat5",
                table: "Pricings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PColoe",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "PFeat4",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "PFeat5",
                table: "Pricings");
        }
    }
}
