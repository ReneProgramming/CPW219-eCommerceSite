using CPW219_eCommerceSite.Data;
using CPW219_eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPW219_eCommerceSite.Controllers
{
    public class GamesController : Controller
    {
        private readonly VideoGameContext _context;

        public GamesController(VideoGameContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game g)
        {
            if (ModelState.IsValid)
            {
                _context.Games.Add(g); // Prepares insert
                _context.SaveChanges(); // Executes pending insert

                ViewData["Message"] = $"{g.Title} was added successfully!";
                return View();
            }

            return View(g);
        }
    }
}
