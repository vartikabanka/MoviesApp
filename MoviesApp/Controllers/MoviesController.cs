using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Models;
using System.Reflection.Metadata;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesAppDbContext movies;//object of class MoviesAppDbContext
        public MoviesController(MoviesAppDbContext movies)
        {
            this.movies = movies;
        }
        
        public async Task<IActionResult> Review()
        {
             return View(await movies.Movies.ToListAsync());
        }
        
        
        public IActionResult AddReview()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReview(Movie movie)
        {
            movies.Add(movie);
            movies.SaveChanges();  
            return RedirectToAction(nameof(Review));
        }



        //Get
        //Edit
        public IActionResult Edit(int Id)
        {
            if (!MovieExist(Id))
            {
                return NotFound("Page Not Found!");
            }

            Movie movie = movies.Movies.Find(Id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(int Id,Movie movie)
        {
                       
            movies.Update(movie);
            movies.SaveChanges();
            return RedirectToAction(nameof(Review));
        }

        //Get - Delete
        public IActionResult Delete(int id)
        {
            Movie movie = movies.Movies.Find(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            movies.Movies.Remove(movie);
            movies.SaveChanges();
            return RedirectToAction(nameof(Review));
            return View();
        }

        private bool MovieExist(int id)
        {
            return (movies.Movies.Any(a=>a.Id==id));
        }

    }
}
