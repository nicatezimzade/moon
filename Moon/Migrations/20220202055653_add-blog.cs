using Microsoft.EntityFrameworkCore.Migrations;

namespace Moon.Migrations
{
    public partial class addblog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogShare1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogShare2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
