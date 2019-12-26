using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Migrations
{
    public partial class InitialMigration : Migration
    {
        // the up method is going to bring the apps database in sync with the apps domain/model.
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pies",
                columns: table => new
                {
                    PieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pies", x => x.PieID);
                });
        }

        // down will bring the domain/model in sync with the apps database?
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pies");
        }
    }
}
