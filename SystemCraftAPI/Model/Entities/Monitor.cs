using System.ComponentModel.DataAnnotations;

namespace SystemCraftAPI.Model.Entities
{
    public class Monitor
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

        [Range(10.0, 50.0)]
        public double ScreenSize { get; set; } // in inches

        [StringLength(20)]
        public string Resolution { get; set; } // e.g., 1920x1080

        [StringLength(20)]
        public string PanelType { get; set; } // e.g., IPS, TN

        [Range(1, int.MaxValue)]
        public int RefreshRate { get; set; } // in Hz

        [Range(1, int.MaxValue)]
        public int ResponseTime { get; set; } // in ms

        [StringLength(20)]
        public string AspectRatio { get; set; } // e.g., 16:9

        public bool HasHDR { get; set; }

        public bool IsCurved { get; set; }

        [StringLength(20)]
        public string Color { get; set; }

        [Range(1, int.MaxValue)]
        public int Brightness { get; set; } // in nits

        [StringLength(20)]
        public string Connectivity { get; set; } // e.g., HDMI, DisplayPort

        public bool HasSpeakers { get; set; }

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
