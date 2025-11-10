using System.ComponentModel.DataAnnotations;

namespace SystemCraftAPI.Model.Entities
{
    public class Computer
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
        public string Processor { get; set; }

        [Range(1, int.MaxValue)]
        public int RAM { get; set; } // in GB

        [Range(1, int.MaxValue)]
        public int Storage { get; set; } // in GB

        [StringLength(20)]
        public string StorageType { get; set; } // e.g., SSD, HDD

        [StringLength(20)]
        public string OperatingSystem { get; set; }

        [StringLength(20)]
        public string CaseType { get; set; } // e.g., Tower, Mini

        [StringLength(50)]
        public string GraphicsCard { get; set; }

        [Range(1, int.MaxValue)]
        public int USBPorts { get; set; }

        public bool HasHDMI { get; set; }

        public bool HasEthernet { get; set; }

        public bool HasWiFi { get; set; }

        [StringLength(20)]
        public string PowerSupply { get; set; } // e.g., 500W

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
