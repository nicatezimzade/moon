using Microsoft.EntityFrameworkCore.Migrations;

namespace Moon.Migrations
{
    public partial class addpricing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PCapacity = table.Column<int>(type: "int", nullable: false),
                    PCapType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFeat1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFeat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFeat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PBtnText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pricings");
        }
    }
}
