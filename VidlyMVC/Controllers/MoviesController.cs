using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using VidlyMVC.Models;
using VidlyMVC.ViewModels;

namespace VidlyMVC.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1 , Name = "The NYC"},
                new Movie {Id = 2 , Name = "The Miami"},
                new Movie {Id = 3 , Name = "The Osceola"}
            };
        }
        public ActionResult Random()
        {
            var movie = new Movie { Name = "New York City" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Lisi"},
                new Customer { Name = "Aisana"},
                new Customer { Name = "Tamara"},
                new Customer { Name = "Yurika"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers   
        };
            return View(viewModel);
         
        }
    }
}
