using System;
using System.Security.Claims;
using EMovies.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EMovies.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ILogger<MoviesController> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        // GET: Products
        public IActionResult Index()
        {
            _logger.LogInformation("User Request -> Get All movies!");
            return View(this._movieService.GetAllProducts());
        }

        // GET: Movies/Details/5
        public IActionResult Details(Guid? id)
        {
            _logger.LogInformation("User Request -> Get Details For Movie");
            if (id == null)
            {
                return NotFound();
            }

            var movie = this._movieService.GetDetailsForMovie(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        public IActionResult Create()
        {
            _logger.LogInformation("User Request -> Get create form for Movie!");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,MovieName,MovieImage,MovieDescription,MovieRating")] Movie movie)
        {
            _logger.LogInformation("User Request -> Inser Movie in DataBase!");
            if (ModelState.IsValid)
            {
                movie.Id = Guid.NewGuid();
                this._movieService.CreateNewProduct(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Products/Edit/5
        public IActionResult Edit(Guid? id)
        {
            _logger.LogInformation("User Request -> Get edit form for Movie!");
            if (id == null)
            {
                return NotFound();
            }

            var movie = this._movieService.GetDetailsForMovie(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,MovieName,MovieImage,MovieDescription,MovieRating")] Movie movie)
        {
            _logger.LogInformation("User Request -> Update Movie in DataBase!");

            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._movieService.UpdeteExistingProduct(movie);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public IActionResult Delete(Guid? id)
        {
            _logger.LogInformation("User Request -> Get delete form for Movie!");

            if (id == null)
            {
                return NotFound();
            }

            var movie = this._movieService.GetDetailsForMovie(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        
       
        private bool ProductExists(Guid id)
        {
            return this._movieService.GetDetailsForMovie(id) != null;
        }
    }
}
