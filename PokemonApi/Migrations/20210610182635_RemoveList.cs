using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonApi.Migrations
{
    public partial class RemoveList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type1",
                table: "Pokemon",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type2",
                table: "Pokemon",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 90,
                column: "Type1",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 279,
                columns: new[] { "Type1", "Type2" },
                values: new object[] { "Water", "Flying" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 493,
                column: "Type1",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 625,
                columns: new[] { "Type1", "Type2" },
                values: new object[] { "Dark", "Steel" });

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 773,
                column: "Type1",
                value: "Normal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type1",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Type2",
                table: "Pokemon");
        }
    }
}
