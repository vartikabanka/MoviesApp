using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        [Required]
        [Display(Name ="Enter your name")]
        public string? Name { get; set; }
        [Required]
        [Display(Name="Enter Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public string? Address{ get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string ProfileImageUrl { get; set; }
    }
}
