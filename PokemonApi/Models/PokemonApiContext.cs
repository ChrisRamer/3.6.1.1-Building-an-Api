using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PokemonApi.Models
{
	public class PokemonApiContext : DbContext
	{
		public DbSet<Pokemon> Pokemon { get; set; }

		public PokemonApiContext(DbContextOptions<PokemonApiContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Pokemon>()
			.HasData(
				new Pokemon { PokemonId = 279, Name = "Pelipper", Description = "It is a messenger of the skies, carrying small Pokémon and eggs to safety in its bill.", Types = new List<string> { "Water", "Flying" } },
				new Pokemon { PokemonId = 773, Name = "Silvally", Description = "A solid bond of trust between this Pokémon and its Trainer awakened the strength hidden within Silvally. It can change its type at will.", Types = new List<string> { "Normal" } },
				new Pokemon { PokemonId = 625, Name = "Bisharp", Description = "It’s accompanied by a large retinue of Pawniard. Bisharp keeps a keen eye on its minions, ensuring none of them even think of double-crossing it.", Types = new List<string> { "Dark", "Steel" } },
				new Pokemon { PokemonId = 493, Name = "Arceus", Description = "According to the legends of Sinnoh, this Pokémon emerged from an egg and shaped all there is in this world.", Types = new List<string> { "Normal" } },
				new Pokemon { PokemonId = 90, Name = "Shellder", Description = "It swims facing backward by opening and closing its two-piece shell. It is surprisingly fast.", Types = new List<string> { "Water" }}
			);
		}
	}
}