using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioApp.Data;
using PortfolioApp.Models;
using PortfolioApp.Services;
using PortfolioApp.ViewModels;

namespace PortfolioApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly FileUploadService _fileUploadService;

        public AdminController(
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            FileUploadService fileUploadService)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _fileUploadService = fileUploadService;
        }

        // ─── LOGIN ───────────────────────────────────────────
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity?.IsAuthenticated == true)
                return RedirectToAction("Dashboard");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var result = await _signInManager.PasswordSignInAsync(
                model.Email, model.Password, model.RememberMe, false);

            if (result.Succeeded)
                return RedirectToAction("Dashboard");

            ModelState.AddModelError("", "Email ose fjalëkalimi i gabuar.");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        // ─── DASHBOARD ───────────────────────────────────────
        [Authorize]
        public async Task<IActionResult> Dashboard()
        {
            var projects = await _context.Projects.OrderBy(p => p.DisplayOrder).ToListAsync();
            var aboutMe = await _context.AboutMes.FirstOrDefaultAsync();
            ViewBag.AboutMe = aboutMe;
            return View(projects);
        }

        // ─── CREATE ──────────────────────────────────────────
        [Authorize]
        [HttpGet]
        public IActionResult Create() => View(new ProjectViewModel());

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(ProjectViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var project = new Project
            {
                Title = model.Title,
                Description = model.Description,
                ShortDescription = model.ShortDescription,
                TechStack = model.TechStack,
                GitHubUrl = model.GitHubUrl,
                LiveUrl = model.LiveUrl,
                IsFeatured = model.IsFeatured,
                DisplayOrder = model.DisplayOrder,
                CreatedAt = DateTime.Now
            };

            if (model.ImageFile != null)
                project.ImagePath = await _fileUploadService.UploadImageAsync(model.ImageFile);

            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Projekti u shtua me sukses!";
            return RedirectToAction("Dashboard");
        }

        // ─── EDIT ────────────────────────────────────────────
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null) return NotFound();

            var model = new ProjectViewModel
            {
                Id = project.Id,
                Title = project.Title,
                Description = project.Description,
                ShortDescription = project.ShortDescription,
                TechStack = project.TechStack,
                GitHubUrl = project.GitHubUrl,
                LiveUrl = project.LiveUrl,
                IsFeatured = project.IsFeatured,
                DisplayOrder = project.DisplayOrder,
                ExistingImagePath = project.ImagePath
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(ProjectViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var project = await _context.Projects.FindAsync(model.Id);
            if (project == null) return NotFound();

            project.Title = model.Title;
            project.Description = model.Description;
            project.ShortDescription = model.ShortDescription;
            project.TechStack = model.TechStack;
            project.GitHubUrl = model.GitHubUrl;
            project.LiveUrl = model.LiveUrl;
            project.IsFeatured = model.IsFeatured;
            project.DisplayOrder = model.DisplayOrder;

            if (model.ImageFile != null)
            {
                _fileUploadService.DeleteImage(project.ImagePath);
                project.ImagePath = await _fileUploadService.UploadImageAsync(model.ImageFile);
            }

            await _context.SaveChangesAsync();
            TempData["Success"] = "Projekti u ndryshua me sukses!";
            return RedirectToAction("Dashboard");
        }

        // ─── DELETE ──────────────────────────────────────────
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null) return NotFound();

            _fileUploadService.DeleteImage(project.ImagePath);
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Projekti u fshi me sukses!";
            return RedirectToAction("Dashboard");
        }

        // ─── EDIT ABOUT ME ───────────────────────────────────
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> EditAbout()
        {
            var about = await _context.AboutMes.FirstOrDefaultAsync();
            return View(about);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> EditAbout(AboutMe model, IFormFile? profileImage)
        {
            var about = await _context.AboutMes.FirstOrDefaultAsync();
            if (about == null) return NotFound();

            about.FullName = model.FullName;
            about.Title = model.Title;
            about.Bio = model.Bio;
            about.Email = model.Email;
            about.GitHubUrl = model.GitHubUrl;
            about.LinkedInUrl = model.LinkedInUrl;

            if (profileImage != null)
            {
                _fileUploadService.DeleteImage(about.ProfileImagePath);
                about.ProfileImagePath = await _fileUploadService.UploadImageAsync(profileImage, "profile");
            }

            await _context.SaveChangesAsync();
            TempData["Success"] = "Profili u ndryshua me sukses!";
            return RedirectToAction("Dashboard");
        }
    }
}