using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_app.Models;
using Vidly_app.ViewModels;

namespace Vidly_app.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult index()
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Name = "Spartacus",

                },
                new Movie
                {
                    Id = 2,
                    Name = "Shrek"
                },
                new Movie
                {
                    Id = 3,
                    Name = "Avengers"
                }
            };

            var movieModel = new MovieViewModel
            {
                Movies = movies
            };
            return View(movieModel);
        }
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Name = "Spartacus"
            };
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Joseph",
                    Phone = 070392

                },
                new Customer
                {
                    Name = "Joseph1",
                    Phone = 070392

                }
            };

            var randomMovieModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(randomMovieModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id =" + id);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content("year = " + year + " month = " + month);
        }


        [Route("movie/customers")]
        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Joseph",
                    Phone = 070392

                },
                new Customer
                {
                    Name = "Joseph1",
                    Phone = 070392

                }
            };
            var custViewModel = new CustomersViewModel
            {
                Customers = customers
            };
            return View(custViewModel);
        }

        [Route("movie/{id}")]
        public ActionResult movie (int id)
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Name = "Spartacus",

                },
                new Movie
                {
                    Id = 2,
                    Name = "Shrek"
                },
                new Movie
                {
                    Id = 3,
                    Name = "Avengers"
                }
            };

            var movie = movies.Find(m => m.Id == id);
            var viewModel = new SingleMovieViewModel
            {
                Movie = movie
            };
            return View(viewModel);
        }
    }
}