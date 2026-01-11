namespace SystemCraftAPI.Model.Entities
{
    public class UserHeadphonesFavorite
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int HeadphonesId { get; set; }
        public Headphones Headphones { get; set; } = null!;
    }
}
