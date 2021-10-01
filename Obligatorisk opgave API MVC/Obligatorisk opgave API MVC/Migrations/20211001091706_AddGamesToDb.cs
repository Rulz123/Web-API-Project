using Microsoft.EntityFrameworkCore.Migrations;

namespace Obligatorisk_opgave_API_MVC.Migrations
{
    public partial class AddGamesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    internalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    metacriticlink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dealID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    storeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gameID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salePrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    normalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isOnSale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    savings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    metacriticscore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    steamRatingText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    steamRatingPercent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    steamRatingCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    steamAppID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    releaseDate = table.Column<int>(type: "int", nullable: false),
                    lastChange = table.Column<int>(type: "int", nullable: false),
                    dealRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thumb = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
