using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter your name!")]
        public string? Reviewer { get; set; }
        [Required(ErrorMessage ="Please enter movie name!")]
        public string? MovieName { get; set; }
        [Required(ErrorMessage ="Please enter your review!")]
        public string?  Review { get; set; }
        [Required(ErrorMessage ="Plese give your rating for the movie!")]
        public int Rating { get; set; }
    }
}
