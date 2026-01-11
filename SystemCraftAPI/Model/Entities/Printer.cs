using System.ComponentModel.DataAnnotations;

namespace SystemCraftAPI.Model.Entities
{
    public class Printer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
    public string Name { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Required]
    public int BrandId { get; set; }

    public Brand Brand { get; set; } = null!;

        [StringLength(50)]
    public string Model { get; set; } = string.Empty;

        [StringLength(20)]
    public string Type { get; set; } = string.Empty; // e.g., Inkjet, Laser

        [StringLength(20)]
    public string PrintTechnology { get; set; } = string.Empty; // e.g., Color, Black & White

        [Range(1, int.MaxValue)]
        public int PrintSpeed { get; set; } // pages per minute

        [StringLength(20)]
    public string Resolution { get; set; } = string.Empty; // e.g., 1200x1200 DPI

        public bool IsWireless { get; set; }

        [StringLength(20)]
    public string Connectivity { get; set; } = string.Empty; // e.g., USB, WiFi

        public bool HasScanner { get; set; }

        public bool HasCopier { get; set; }

        [StringLength(20)]
    public string PaperSize { get; set; } = string.Empty; // e.g., A4, Letter

        [Range(1, int.MaxValue)]
        public int DutyCycle { get; set; } // pages per month

        [StringLength(10)]
    public string Warranty { get; set; } = string.Empty; // e.g., 1 year

        public DateTime ReleaseDate { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; } // out of 5

        public bool InStock { get; set; }

        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }
    }
}
