using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Genomgång.Controllers
{
    [Produces("application/json")]
    [Route("api/Pokemon")]
    public class PokemonController : Controller
    {
        public static List<Pokemon> pokemon = new List<Pokemon>()
        {
            new Pokemon() {Name = "Ekans", Strength = 67},
            new Pokemon() {Name = "Bublbasaur", Strength = 200},
            new Pokemon() {Name = "Eevee", Strength = 97}
        };

        [HttpGet]
        public ActionResult MyPerfectGet()
        {
            Pokemon p = new Pokemon();
            p.Name = "Ekans";
            p.Strength = 67;

            return Ok(pokemon);
        }

        [HttpPost]
        public ActionResult AddNewPokemon(Pokemon newPokemon)
        {
            pokemon.Add(newPokemon);
            Console.WriteLine();

            return Created("", newPokemon);
        }
    }
}