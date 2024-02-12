using System.ComponentModel.DataAnnotations;

namespace MyShop.Models
{
    public class Bicycle
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Brand is Required")]
        public string? Brand { get; set; }

        [Required(ErrorMessage = "Model is Required")]
        public string? Model { get; set; }

        [Range(2000, 2024, ErrorMessage = "Year must be between 2000 and 2024")]
        [Required(ErrorMessage ="Year is required")]
        public int? Year { get; set; }

        [Required(ErrorMessage ="Type is required")]
        public string? Type { get; set; } //Mountain, Road, Hybrid, Tri

        [Required(ErrorMessage ="Price is required")]
        [Range(0, 30000, ErrorMessage = "Price must be between 0 and 30000")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage ="Color is required")]
        public string? Color { get; set; }

        public string? ImageFileName { get; set; }

        //Slug read only property
        public string Slug => $"{Brand}-{Model}-{Year}".ToLower().Replace(" ", "-");   
    }
}
