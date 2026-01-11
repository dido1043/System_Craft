using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SystemCraftAPI.Model.Entities
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string Country { get; set; } = string.Empty;

        [StringLength(200)]
        public string Website { get; set; } = string.Empty;

        public ICollection<Computer> Computers { get; set; } = new List<Computer>();
        public ICollection<GraphicsCard> GraphicsCards { get; set; } = new List<GraphicsCard>();
        public ICollection<Headphones> Headphones { get; set; } = new List<Headphones>();
        public ICollection<Keyboard> Keyboards { get; set; } = new List<Keyboard>();
        public ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();
        public ICollection<Monitor> Monitors { get; set; } = new List<Monitor>();
        public ICollection<Mouse> Mice { get; set; } = new List<Mouse>();
        public ICollection<Printer> Printers { get; set; } = new List<Printer>();
        public ICollection<Webcam> Webcams { get; set; } = new List<Webcam>();
    }
}
