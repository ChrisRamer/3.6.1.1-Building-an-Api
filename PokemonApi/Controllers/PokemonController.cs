using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PokemonController : ControllerBase
	{
		private PokemonApiContext _db;

		public PokemonController(PokemonApiContext db)
		{
			_db = db;
		}

		// GET api/pokemon
		[HttpGet]
		public ActionResult<IEnumerable<Pokemon>> Get(int index, string name)
		{
			var query = _db.Pokemon.AsQueryable();

			if (index > 0)
			{
				query = query.Where(entry => entry.PokemonId == index);
			}

			if (name != null)
			{
				query = query.Where(entry => entry.Name == name);
			}

			return query.ToList();
		}

		// Post api/pokemon/5
		[HttpPost]
		public void Post([FromBody] Pokemon pokemon)
		{
			_db.Pokemon.Add(pokemon);
			_db.SaveChanges();
		}

		// GET api/pokemon/5
		[HttpGet("{id}")]
		public ActionResult<Pokemon> GetActionResult(int id)
		{
			return _db.Pokemon.FirstOrDefault(entry => entry.PokemonId == id);
		}

		// PUT api/pokemon/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Pokemon pokemon)
		{
			pokemon.PokemonId = id;
			_db.Entry(pokemon).State = EntityState.Modified;
			_db.SaveChanges();
		}

		// DELETE api/pokemon/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			Pokemon pokemonToDelete = _db.Pokemon.FirstOrDefault(entry => entry.PokemonId == id);
			_db.Pokemon.Remove(pokemonToDelete);
			_db.SaveChanges();
		}
	}
}