using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pokedex.Models;

namespace Pokedex.Controllers
{
    public class PokedexController : Controller
    {
        public ActionResult Home()
        {
            using (PokedexEntities db = new PokedexEntities())
            {
                List<tblPokemon> list = db.tblPokemons.Where(x => x.iNumber > 10 && x.iNumber < 100).ToList();

                //foreach (var pokemon in list)
                //{
                //    pokemon.vcType = "Fire";
                //}

                //foreach (var pkm in db.tblPokemons.Where(p => p.vcName == "Bulbasaur"))
                //{
                //    pkm.vcName = "Steve";
                //}

                tblPokemon bulb = db.tblPokemons.FirstOrDefault(x => x.vcName == "Bulbasaur");
                bulb.vcName = "Steve";

                db.SaveChanges();

                return View(list);
            }
        }
    }
}