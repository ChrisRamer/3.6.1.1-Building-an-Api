using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokemonApi.Models
{
	public class Pokemon
	{
		public int PokemonId { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public List<string> Types = new List<string>();
	}
}