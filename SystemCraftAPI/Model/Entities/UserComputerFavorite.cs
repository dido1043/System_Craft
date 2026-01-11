namespace SystemCraftAPI.Model.Entities
{
    public class UserComputerFavorite
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ComputerId { get; set; }
        public Computer Computer { get; set; } = null!;
    }
}
