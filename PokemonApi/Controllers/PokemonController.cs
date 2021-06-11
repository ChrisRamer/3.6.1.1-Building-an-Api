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

		/*
		// GET api/pokemon
		[HttpGet]
		public ActionResult<IEnumerable<Pokemon>> Get(int index, string name)
		{
			return null;
		}
		*/
	}
}