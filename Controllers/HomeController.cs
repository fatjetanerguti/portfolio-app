using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioApp.Data;

namespace PortfolioApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var projects = await _context.Projects
                .OrderBy(p => p.DisplayOrder)
                .ToListAsync();

            var skills = await _context.Skills
                .OrderBy(s => s.DisplayOrder)
                .ToListAsync();

            var aboutMe = await _context.AboutMes.FirstOrDefaultAsync();

            ViewBag.Projects = projects;
            ViewBag.Skills = skills;
            ViewBag.AboutMe = aboutMe;

            return View();
        }
    }
}