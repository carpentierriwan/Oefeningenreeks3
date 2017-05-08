using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Oefeningenreeks3.Controllers
{
    public class BandlidController : Controller
    {
        private List<Band> bands = new List<Band>() {
                new Band() { Naam="The Beatles", Jaar=1960,
                    Bandleden = new List<Bandlid>()
                        {
                            new Bandlid() { Naam="George", Geslacht=Geslacht.Man, Leeftijd=55, Levend=false },
                            new Bandlid() { Naam="Ringo", Geslacht=Geslacht.Man, Leeftijd=64, Levend=true },
                            new Bandlid() { Naam="Paul", Geslacht=Geslacht.Man, Leeftijd=76, Levend=true },
                            new Bandlid() { Naam="John", Geslacht=Geslacht.Man, Leeftijd=35, Levend=false }
                        }
                },
                new Band() { Naam="Nicole & Hugo", Jaar=1302,
                    Bandleden = new List<Bandlid>()
                        {
                            new Bandlid() { Naam="Nicole", Geslacht=Geslacht.Vrouw, Leeftijd=105, Levend=true },
                            new Bandlid() { Naam="Hugo", Geslacht=Geslacht.Man, Leeftijd=103, Levend=true },
                        }
                }
            };

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lijst()
        {
            ViewBag.Bands = bands;
            return View();
        }

        public IActionResult Maak(string naam, int jaar, Geslacht geslacht, string band)
        {
            bands.Add(
                new Band()
                {
                    Naam = band, // geen rekening mee houden dat de band al kan bestaan? ok
                    Bandleden = new List<Bandlid>()
                    { new Bandlid() { Naam = naam, Geslacht = geslacht, Leeftijd = 2017 - jaar } } // die leeftijd is ook niet optimaal maar bon
                });
            ViewBag.Bands = bands;
            return View("Lijst");
        }
    }
}
