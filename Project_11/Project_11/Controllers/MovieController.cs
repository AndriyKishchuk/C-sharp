using Microsoft.AspNetCore.Mvc;
using Project_11.Models;


namespace Project_11.Controllers
{
    public class MovieController(MovieService movieService) : Controller
    {
        public IActionResult Index(string? genre, int? year)
        {
            ViewBag.Genre = movieService.GetAllGenres();
            ViewBag.SelectedGenre = genre;
            ViewBag.SelectedYear = year;
            ViewBag.Years = movieService.GetAllYears();

            var movies = movieService.Filter(genre, year);
            return View(movies);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid) return View(movie);
            movieService.AddMovie(movie);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var movie = movieService.GetMovieById(id);
            if (movie == null) return NotFound();

            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Movie movie)
        {
            if (!ModelState.IsValid) return View(movie);

            movieService.UpdateMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var movie = movieService.GetMovieById(id);
            if (movie == null) return NotFound();

            return View(movie);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            movieService.DeleteMovie(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

