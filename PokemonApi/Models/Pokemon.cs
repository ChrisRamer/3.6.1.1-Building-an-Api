using System.ComponentModel.DataAnnotations;

namespace PokemonApi.Models
{
	public class Pokemon
	{
		public int PokemonId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}