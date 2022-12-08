using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name ="Name of Product")]
        public string? ProductName { get; set; }
        [Required]
        [Display(Name ="Description of Product")]
        public string? Description { get; set; }
        public decimal MRP { get; set; }
        public Photo? photo { get; set; }
        [Required(ErrorMessage ="Please upload image of the product!")]
        [NotMapped]
        [FromForm]
        public IFormFile? ProductImage { get; set; }
    }
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public byte[]?  ImageData { get; set; }
        public string? Description { get; set; }
        public string? FileExtension { get; set; }
        public decimal Size { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }

}
