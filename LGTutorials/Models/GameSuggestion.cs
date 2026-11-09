using System.ComponentModel.DataAnnotations;

namespace LGTutorials.Models
{
    public class GameSuggestion
    {

        [Required(ErrorMessage = "Please enter a game title.")]
        [StringLength(10, ErrorMessage = "Title cannot exceed 50 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Range(1970, 2026, ErrorMessage = "Enter a valid release year.")]
        public int? Year { get; set; }
    }
}
