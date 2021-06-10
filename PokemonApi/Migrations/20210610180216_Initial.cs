using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    PokemonId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.PokemonId);
                });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "PokemonId", "Description", "Name" },
                values: new object[,]
                {
                    { 279, "It is a messenger of the skies, carrying small Pokémon and eggs to safety in its bill.", "Pelipper" },
                    { 773, "A solid bond of trust between this Pokémon and its Trainer awakened the strength hidden within Silvally. It can change its type at will.", "Silvally" },
                    { 625, "It’s accompanied by a large retinue of Pawniard. Bisharp keeps a keen eye on its minions, ensuring none of them even think of double-crossing it.", "Bisharp" },
                    { 493, "According to the legends of Sinnoh, this Pokémon emerged from an egg and shaped all there is in this world.", "Arceus" },
                    { 90, "It swims facing backward by opening and closing its two-piece shell. It is surprisingly fast.", "Shellder" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");
        }
    }
}
