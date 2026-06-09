using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class AboutMe
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Title { get; set; }

        public string? Bio { get; set; }

        public string? ProfileImagePath { get; set; }

        public string? Email { get; set; }

        public string? GitHubUrl { get; set; }

        public string? LinkedInUrl { get; set; }

        public string? CVPath { get; set; }
    }
}