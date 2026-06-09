using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortfolioApp.Models;

namespace PortfolioApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<AboutMe> AboutMes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Title = "EBiblioteka",
                    ShortDescription = "Librari online me libra dhe e-books",
                    Description = "Sistem librarie online që lejon përdoruesit të shfletojnë, lexojnë dhe menaxhojnë libra dhe e-books dixhitale. Ndërtuar me ASP.NET Core MVC dhe SQL Server.",
                    TechStack = "C#, ASP.NET Core, SQL Server",
                    GitHubUrl = "https://github.com/fatjetanerguti/EBiblioteka",
                    IsFeatured = true,
                    DisplayOrder = 1,
                    CreatedAt = new DateTime(2024, 1, 1)
                },
                new Project
                {
                    Id = 2,
                    Title = "Realproject3",
                    ShortDescription = "Projekt i avancuar me TypeScript",
                    Description = "Projekt web i ndërtuar me TypeScript duke aplikuar arkitekturë të strukturuar dhe parimet e programimit modern.",
                    TechStack = "TypeScript, JavaScript",
                    GitHubUrl = "https://github.com/fatjetanerguti/Realproject3",
                    IsFeatured = true,
                    DisplayOrder = 2,
                    CreatedAt = new DateTime(2024, 1, 1)
                },
                new Project
                {
                    Id = 3,
                    Title = "Coffee Website",
                    ShortDescription = "Faqe web elegante për kafene",
                    Description = "Faqe web responsive dhe elegante për prezantimin e një kafeneje. Dizajnuar me CSS të avancuar dhe HTML5 semantik.",
                    TechStack = "HTML5, CSS3, JavaScript",
                    GitHubUrl = "https://github.com/fatjetanerguti/coffee-website",
                    IsFeatured = false,
                    DisplayOrder = 3,
                    CreatedAt = new DateTime(2024, 1, 1)
                },
                new Project
                {
                    Id = 4,
                    Title = "Projekt Intership",
                    ShortDescription = "Projekt i zhvilluar gjatë internshipit",
                    Description = "Projekt web i realizuar gjatë periudhës së internshipit, duke demonstruar aftësi praktike në zhvillim frontend me HTML dhe CSS.",
                    TechStack = "HTML5, CSS3",
                    GitHubUrl = "https://github.com/fatjetanerguti/FatjetaProjektIntership",
                    IsFeatured = false,
                    DisplayOrder = 4,
                    CreatedAt = new DateTime(2024, 1, 1)
                },
                new Project
                {
                    Id = 5,
                    Title = "Fati Coffee Shop",
                    ShortDescription = "Projekt minimalist për kafene",
                    Description = "Projekt i vogël dhe minimalist për prezantimin e një kafeneje, me dizajn të pastër dhe modern duke përdorur HTML dhe CSS.",
                    TechStack = "HTML5, CSS3",
                    GitHubUrl = "https://github.com/fatjetanerguti/FatiCofeeShop",
                    IsFeatured = false,
                    DisplayOrder = 5,
                    CreatedAt = new DateTime(2024, 1, 1)
                }
            );

            builder.Entity<Skill>().HasData(
                // Frontend
                new Skill { Id = 1, Name = "HTML5 & CSS3", Category = "Frontend", Level = 92, DisplayOrder = 1 },
                new Skill { Id = 2, Name = "JavaScript", Category = "Frontend", Level = 80, DisplayOrder = 2 },
                new Skill { Id = 3, Name = "React.js", Category = "Frontend", Level = 85, DisplayOrder = 3 },
                new Skill { Id = 4, Name = "Next.js", Category = "Frontend", Level = 78, DisplayOrder = 4 },
                new Skill { Id = 5, Name = "TypeScript", Category = "Frontend", Level = 70, DisplayOrder = 5 },
                new Skill { Id = 6, Name = "Bootstrap", Category = "Frontend", Level = 85, DisplayOrder = 6 },
                // Design
                new Skill { Id = 7, Name = "Figma / UX·UI", Category = "Design", Level = 80, DisplayOrder = 7 },
                new Skill { Id = 8, Name = "Responsive Design", Category = "Design", Level = 90, DisplayOrder = 8 },
                // Backend
                new Skill { Id = 9, Name = "C# / ASP.NET Core", Category = "Backend", Level = 72, DisplayOrder = 9 },
                new Skill { Id = 10, Name = "MySQL / SQL Server", Category = "Database", Level = 70, DisplayOrder = 10 },
                // Tools
                new Skill { Id = 11, Name = "Git & GitHub", Category = "Tools", Level = 82, DisplayOrder = 11 },
                new Skill { Id = 12, Name = "Docker", Category = "Tools", Level = 55, DisplayOrder = 12 }
            );

            builder.Entity<AboutMe>().HasData(
                new AboutMe
                {
                    Id = 1,
                    FullName = "Fatjeta Nerguti",
                    Title = "Front-End Developer & ICT Student",
                    Bio = "Zhvilluese Front-End e motivuar me 1+ vit trajnim dhe ekspertizë të certifikuar në HTML5, CSS3, JavaScript, React.js dhe Next.js. Kam përfunduar programin 12-mujor Brainster me rezultat 92% dhe 180 kredite. Aktualisht ndjek BSc në Teknologji Informacioni dhe Komunikimi në Universitetin e Tiranës.",
                    Email = "fatjetanerguti8@gmail.com",
                    GitHubUrl = "https://github.com/fatjetanerguti",
                    LinkedInUrl = ""
                }
            );
        }
    }
}