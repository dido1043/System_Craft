namespace SystemCraftAPI.Model.Entities
{
    public class UserLaptopFavorite
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int LaptopId { get; set; }
        public Laptop Laptop { get; set; } = null!;
    }
}
