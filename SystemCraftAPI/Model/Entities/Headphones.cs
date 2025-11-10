using System.ComponentModel.DataAnnotations;

namespace SystemCraftAPI.Model.Entities
{
    public class Headphones
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(20)]
        public string Type { get; set; } // e.g., Over-ear, In-ear

        public bool IsWireless { get; set; }

        [StringLength(20)]
        public string Connectivity { get; set; } // e.g., Bluetooth, Wired

        public bool HasMicrophone { get; set; }

        [Range(1, int.MaxValue)]
        public int BatteryLife { get; set; } // in hours

        [StringLength(20)]
        public string DriverSize { get; set; } // e.g., 40mm

        [StringLength(20)]
        public string FrequencyResponse { get; set; } // e.g., 20Hz-20kHz

        public bool IsNoiseCancelling { get; set; }

        [StringLength(20)]
        public string Color { get; set; }

        [Range(0.01, double.MaxValue)]
        public double Weight { get; set; } // in kg

        public bool IsFoldable { get; set; }

        [StringLength(10)]
        public string Warranty { get; set; } // e.g., 1 year

        public DateTime ReleaseDate { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; } // out of 5

        public bool InStock { get; set; }

        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }
    }
}
