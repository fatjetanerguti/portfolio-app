using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public string? ShortDescription { get; set; }

        [MaxLength(500)]
        public string? TechStack { get; set; }

        public string? ImagePath { get; set; }

        public string? GitHubUrl { get; set; }

        public string? LiveUrl { get; set; }

        public bool IsFeatured { get; set; } = false;

        public int DisplayOrder { get; set; } = 0;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}