using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Category { get; set; }

        public int Level { get; set; } = 80;

        public string? IconClass { get; set; }

        public int DisplayOrder { get; set; } = 0;
    }
}