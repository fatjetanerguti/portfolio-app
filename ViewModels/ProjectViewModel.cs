using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulli është i detyrueshëm")]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Përshkrimi është i detyrueshëm")]
        public string Description { get; set; } = string.Empty;

        public string? ShortDescription { get; set; }

        public string? TechStack { get; set; }

        public IFormFile? ImageFile { get; set; }

        public string? ExistingImagePath { get; set; }

        public string? GitHubUrl { get; set; }

        public string? LiveUrl { get; set; }

        public bool IsFeatured { get; set; }

        public int DisplayOrder { get; set; }
    }
}