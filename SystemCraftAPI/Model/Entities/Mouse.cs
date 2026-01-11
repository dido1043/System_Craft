using System.ComponentModel.DataAnnotations;

namespace SystemCraftAPI.Model.Entities
{
    public class Mouse
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
    public string Type { get; set; } = string.Empty; // e.g., Optical, Laser

        public bool IsWireless { get; set; }

        [Range(1, int.MaxValue)]
        public int DPI { get; set; }

        [Range(1, int.MaxValue)]
        public int Buttons { get; set; }

        [StringLength(20)]
    public string Color { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue)]
        public double Weight { get; set; } // in kg

        [StringLength(20)]
    public string Connectivity { get; set; } = string.Empty; // e.g., USB, Bluetooth

        public bool HasScrollWheel { get; set; }

        public bool IsErgonomic { get; set; }

        [Range(1, int.MaxValue)]
        public int BatteryLife { get; set; } // in hours

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
