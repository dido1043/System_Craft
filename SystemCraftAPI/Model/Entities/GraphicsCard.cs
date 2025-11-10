using System.ComponentModel.DataAnnotations;

namespace SystemCraftAPI.Model.Entities
{
    public class GraphicsCard
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

        [StringLength(50)]
        public string Chipset { get; set; } // e.g., NVIDIA RTX 3080

        [Range(1, int.MaxValue)]
        public int VRAM { get; set; } // in GB

        [StringLength(20)]
        public string MemoryType { get; set; } // e.g., GDDR6

        [Range(1, int.MaxValue)]
        public int MemoryBus { get; set; } // in bits

        [Range(1, int.MaxValue)]
        public int CoreClock { get; set; } // in MHz

        [Range(1, int.MaxValue)]
        public int BoostClock { get; set; } // in MHz

        [StringLength(20)]
        public string Interface { get; set; } // e.g., PCIe 4.0

        [Range(1, int.MaxValue)]
        public int PowerConsumption { get; set; } // in Watts

        [StringLength(20)]
        public string CoolingType { get; set; } // e.g., Air, Liquid

        [Range(1, int.MaxValue)]
        public int Length { get; set; } // in mm

        public bool SupportsRayTracing { get; set; }

        public bool SupportsDLSS { get; set; }

        [StringLength(20)]
        public string Ports { get; set; } // e.g., HDMI, DisplayPort

        [StringLength(10)]
        public string Warranty { get; set; } // e.g., 3 years

        public DateTime ReleaseDate { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; } // out of 5

        public bool InStock { get; set; }

        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }
    }
}
