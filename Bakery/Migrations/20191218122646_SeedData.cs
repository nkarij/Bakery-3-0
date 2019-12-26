using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieID", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "Apple Pie", 12.96m, "Our famous apple pies" },
                    { 2, "Brownie", 5.25m, "Our famous Brownie" },
                    { 3, "Chery Pie", 3.16m, "Twin Peaks famous Cherry pies" },
                    { 5, "Othello Cake", 112.96m, "Our expensive Othello Cake" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieID",
                keyValue: 5);
        }
    }
}
