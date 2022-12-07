using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Display(Name = "Upload your profile image")]
        public string ProfileImageUrl { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }


    }
}
