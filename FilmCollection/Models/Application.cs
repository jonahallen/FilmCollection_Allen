using FilmCollection_Allen.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmCollection.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        //public Category Category { get; set; }
        [Required(ErrorMessage = "You must enter a title.")]
        public string Title { get; set; }
        [Required]
        [Range(1888, 2024, ErrorMessage = "You must enter a valid year.")]
        public int Year { get; set; } = 0;
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
