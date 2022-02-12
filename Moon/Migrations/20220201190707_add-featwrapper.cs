using Microsoft.EntityFrameworkCore.Migrations;

namespace Moon.Migrations
{
    public partial class addfeatwrapper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeatWrappers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatWrapperIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatWrapperTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatWrapperText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatWrapperImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatWrappers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatWrappers");
        }
    }
}
