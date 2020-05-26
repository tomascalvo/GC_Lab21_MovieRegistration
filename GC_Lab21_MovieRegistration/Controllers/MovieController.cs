using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
//Using statement for the Models folder?:
using GC_Lab21_MovieRegistration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GC_Lab21_MovieRegistration.Controllers
{
    public class MovieController : Controller
    {
        public List<Movie> defaultMovies = new List<Movie>()
        {
            new Movie(1, "Titanic", Genre.Horror, 1999, "Leonardo DiCaprio", "James Cameron", 6.99, 240),
            new Movie(2, "Alien", Genre.Horror, 1976, "Sigourney Weaver", "Ridley Scott", 6.99, 120),
            new Movie(3, "The Matrix", Genre.ScienceFiction, 1999, "Keanu Reeves", "The Wachowski Siblings", 6.99, 121),
            new Movie(4, "Sicario", Genre.Western, 2011, "Javier Bardem", "Denis Villenueve", 6.99, 122)
        };

        //The list below is "an empty global List<Model> at the top of the controller". I've written this list following Anna's state management checklist. I think this list is a "SESSIONLIST". This SESSIONLIST allows me to set and retain session values?
        public List<Movie> shoppingCart = new List<Movie>();

        string shoppingCartJSON = HttpContext.Session.GetString("SessionName") ?? "AltString";



        public IActionResult Index()
        {
            return View(defaultMovies);
        }

        public IActionResult AddToCart(Movie movie)
        {
            return RedirectToAction("Index");
        }
    }
}
