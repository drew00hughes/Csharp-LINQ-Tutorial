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
            return View();
        }
    }
}