using System.ComponentModel.DataAnnotations;

namespace SystemCraftAPI.Model.Entities
{
    public class Laptop
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

    [StringLength(50)]
    public string Processor { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int RAM { get; set; } // in GB

        [Range(1, int.MaxValue)]
        public int Storage { get; set; } // in GB

    [StringLength(20)]
    public string StorageType { get; set; } = string.Empty; // e.g., SSD, HDD

        [Range(10.0, 20.0)]
        public double ScreenSize { get; set; } // in inches

    [StringLength(20)]
    public string Resolution { get; set; } = string.Empty; // e.g., 1920x1080

    [StringLength(20)]
    public string OperatingSystem { get; set; } = string.Empty;

        [Range(0, int.MaxValue)]
        public int BatteryLife { get; set; } // in hours

        [Range(0.1, double.MaxValue)]
        public double Weight { get; set; } // in kg

    [StringLength(20)]
    public string Color { get; set; } = string.Empty;

        public bool HasTouchscreen { get; set; }

        public bool HasBacklitKeyboard { get; set; }

    [StringLength(50)]
    public string GraphicsCard { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int USBPorts { get; set; }

        public bool HasHDMI { get; set; }

        public bool HasEthernet { get; set; }

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
