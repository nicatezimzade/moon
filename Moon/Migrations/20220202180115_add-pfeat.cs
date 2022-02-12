using Microsoft.EntityFrameworkCore.Migrations;

namespace Moon.Migrations
{
    public partial class addpfeat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PFeat1",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "PFeat2",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "PFeat3",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "PFeat4",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "PFeat5",
                table: "Pricings");

            migrationBuilder.AddColumn<int>(
                name: "PFeatId",
                table: "Pricings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PFeats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFeats", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pricings_PFeatId",
                table: "Pricings",
                column: "PFeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pricings_PFeats_PFeatId",
                table: "Pricings",
                column: "PFeatId",
                principalTable: "PFeats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pricings_PFeats_PFeatId",
                table: "Pricings");

            migrationBuilder.DropTable(
                name: "PFeats");

            migrationBuilder.DropIndex(
                name: "IX_Pricings_PFeatId",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "PFeatId",
                table: "Pricings");

            migrationBuilder.AddColumn<string>(
                name: "PFeat1",
                table: "Pricings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PFeat2",
                table: "Pricings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PFeat3",
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
    }
}
